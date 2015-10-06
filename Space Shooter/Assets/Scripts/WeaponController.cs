/*
 *WeaponController.cs
 *Zhaoning Cai
 *300817368
 *2D Space Shooter Game
 *Last modified on: 5th Oct, 2015
 *Make enemy space ship fire
 *Final revision
*/
using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    void Start()
    {
        InvokeRepeating("Fire", delay, fireRate);
    }

    void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        GetComponent<AudioSource>().Play();
    }
}
