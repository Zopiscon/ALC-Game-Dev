using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private float xRange = 82f;
    private float zRange = 120f;
    private float smallzRange = -29f;
    private float smallxRange = -40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.x > xRange)
        {
            Destroy(gameObject);
        }
        
        if(transform.position.x < smallxRange)
        {
           Destroy(gameObject);
        }

        if(transform.position.z > zRange)
        {
             Destroy(gameObject);
        }

        if(transform.position.z < smallzRange)
        {
             Destroy(gameObject);
        }
    }
}
