using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 15f;
    public GameObject foodProjectile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        
        //constrains leftward movement x @ -10
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            
        }
        
        //constrains rightward movement x @ 10
        if(transform.position.x = xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodProjectile, transform.position, foodProjectile.transform.rotation);
        }
    }
}
