/*
 *Zhaoning Cai
 *300817368
 *2D Space Shooter Game
*/
using UnityEngine;
using System.Collections;

public class PickedUpByContact : MonoBehaviour {

    public int scoreValue;
    private GameController gameController;


    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Enemy" || other.tag == "Bolt")
        {
            return;
        }

        if (other.tag == "Player")
        {
            gameController.AddScore(scoreValue);
            
        }
        
        Destroy(gameObject);
    }
}
