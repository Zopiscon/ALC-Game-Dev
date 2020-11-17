﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontoller : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityMod;
    
    public bool isOnGround = true;
    public bool gameOver = false;
    
    private Animator playerAnim;
    public ParticleSystem explosion;
    public ParticleSystem dirt;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;

        playerAnim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirt.Stop();
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirt.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int",1);
            explosion.Play();
            dirt.Stop();
        }
    }
}
