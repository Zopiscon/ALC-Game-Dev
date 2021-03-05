using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int pointValue = 1;
    public GameManager gms;
     void Start() {
        {
            gms = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
    }
     private void OnTriggerEnter(Collider other)
    {
       gms.UpdateScore(pointValue);
        // Destroy this object
        Destroy(gameObject);
        // Destroy other object this object is colliding with
        Destroy(other.gameObject);
    }
}