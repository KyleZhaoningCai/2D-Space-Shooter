/*
 *Zhaoning Cai
 *300817368
 *2D Space Shooter Game
*/
using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
