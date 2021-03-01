using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    // Start is called before the first frame update
    void OnCollisionEnter()
    {
        Debug.Log($"You've bumped into something {score++} times");        
    }

    // Update is called once per frame
    void Update()
    {        
    }
}
