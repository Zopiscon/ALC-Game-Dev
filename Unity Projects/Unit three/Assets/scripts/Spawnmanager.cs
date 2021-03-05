using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3 (30, 0, 0);
    private float startDelay = 2;
    private float repeatDelay = 2;
    private Playercontoller pcs;
    
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
       pcs = GameObject.Find("Player").GetComponent<Playercontoller>();
    }
    
    void SpawnObstacle()
    {   
        if(pcs.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
