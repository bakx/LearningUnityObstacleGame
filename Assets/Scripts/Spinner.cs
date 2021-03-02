using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateX = 0;
    [SerializeField] float rotateY = 0;
    [SerializeField] float rotateZ = 0;

    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(
            rotateX > 0 ? rotateX * Time.deltaTime : 0, 
            rotateY > 0 ? rotateY * Time.deltaTime : 0,
            rotateZ > 0 ? rotateZ * Time.deltaTime : 0
            );
        }
}
