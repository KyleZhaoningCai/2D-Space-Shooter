/*
 *Zhaoning Cai
 *300817368
 *2D Space Shooter Game
*/
using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{

    public float tumble;

    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
