﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float Speed;

    private Transform backPoint;

    private Animator animator;

    private Rigidbody2D rig;

    void Start() {
        backPoint = GameObject.Find("backPoint").GetComponent<Transform>();    

        animator = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();

    }
    
    void Update()
    {
           //transform.Translate(Vector3.left * Speed * Time.deltaTime); 
        if(GameController.current.PlayerIsAlive)
        {
           rig.velocity = new Vector2(-Speed, rig.velocity.y);

           if(transform.position.x < backPoint.position.x)
           {
               Destroy(gameObject);
           }
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.tag == "bullet")
        {
            GetComponent<CircleCollider2D>().enabled = false;
            GameController.current.AddScore(10); //ao matar inimigo ganha 10 moedas.
            animator.SetTrigger("destroy");
            Destroy(gameObject, 1f);
        }   
    }
}





















