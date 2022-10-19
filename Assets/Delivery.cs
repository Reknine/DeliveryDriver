using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Hi, I'm a collision!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Package picked up");
        }
        else
        {
            Debug.Log("Package delivered to the customer!");
        }
    }
}
