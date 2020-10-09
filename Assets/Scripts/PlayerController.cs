﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float speed = 0;

	private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    [Header("Set Dynamically")] 
    public Text     scoreGT;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        GameObject scoreGO = GameObject.Find("ScoreCounter"); 
        scoreGT = scoreGO.GetComponent<Text>(); 
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable")) 
        {
            other.gameObject.SetActive(false);

            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString(); 
            
        }
    }

}
