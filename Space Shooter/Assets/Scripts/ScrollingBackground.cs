/*
 *Zhaoning Cai
 *300817368
 *2D Space Shooter Game
*/
using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {

    public float speed = 0;
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Renderer>().material.mainTextureOffset = new Vector3(Time.time * speed, 0f, 0f);
	}
}
