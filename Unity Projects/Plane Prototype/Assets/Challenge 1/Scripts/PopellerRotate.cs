using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopellerRotate : MonoBehaviour
{
    public float rotationSpeed = 500;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Rotates the propeller
    transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
