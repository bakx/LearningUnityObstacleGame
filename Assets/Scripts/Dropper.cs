using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;
    [SerializeField] bool isEnabled = true;
    [SerializeField] bool hasGravity = true;


    MeshRenderer meshRenderer;
    new Rigidbody rigidbody;

    
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = isEnabled;

        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = hasGravity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait) 
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
