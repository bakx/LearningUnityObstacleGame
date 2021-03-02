using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Event that occurs when a collision starts
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player") 
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }

    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player") 
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
