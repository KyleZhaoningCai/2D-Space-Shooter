/*
 *Zhaoning Cai
 *300817368
 *2D Space Shooter Game
*/
using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

    public float lifetime;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
