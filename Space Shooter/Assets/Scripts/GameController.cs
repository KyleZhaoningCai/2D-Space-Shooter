/*
 *Zhaoning Cai
 *300817368
 *2D Space Shooter Game
*/
using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public GUIText scoreText;
    public GUIText restartText;
    public GUIText gameOverText;
    public GUIText lifeText;

    private bool gameOver;
    private bool restart;
    private int score;
    private int life;

    public int Life
    {
        get
        {
            return this.life;
        }
        set
        {
            this.life = value;
        }
    }


    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        lifeText.text = "";
        score = 0;
        life = 3;
        UpdateScore();
        UpdateLife();
        StartCoroutine(SpawnWaves());
    }

    void Update ()
    {
        if (restart)
        {
            if (Input.GetKeyDown (KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range( -(spawnValues.x - (float)1.1), spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }
        }
    }

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    void UpdateScore ()
    {
        scoreText.text = "Score: " + score;
    }
    public void GameOver ()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }
    public void MinusLife()
    {
        life -= 1;
        UpdateLife();
    }
    void UpdateLife ()
    {
        lifeText.text = "Life: " + life;
        
    }
}
