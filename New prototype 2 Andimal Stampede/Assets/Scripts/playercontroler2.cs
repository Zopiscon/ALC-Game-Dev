using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler2 : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 20f;
    public GameObject foodMissile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // alows for left and right movement for character
        horizontalInput = Input.GetAxis("horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        // limits x bounds for rightward movement
        if(transform.position.x < xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        
        }
        // limits x bounds for leftward movement
        if(transform.position.x > -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodMissile, transform.position, foodMissile.transform.rotation);
        }
    }
}
