using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 10;
    public float turnSpeed = 100;

    private float forwardInput;
    private float turnInput;
    private float xRange = 52f;
    private float zRange = 82f;
    private float smallzRange = -3f;
    private float smallxRange = -30f;

    public GameObject fireBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turnInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * turnInput * Time.deltaTime);
        // Bouderies for player
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3 (xRange, transform.position.y, transform.position.z);
        }
        
        if(transform.position.x < smallxRange)
        {
            transform.position = new Vector3 (smallxRange, transform.position.y, transform.position.z);
        }

        if(transform.position.z > zRange)
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y, zRange);
        }

        if(transform.position.z < smallzRange)
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y, smallzRange);
        }
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over");
        }

    }
}
