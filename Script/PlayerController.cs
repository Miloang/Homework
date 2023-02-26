using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    public string playerName;
    
    public int Health,Damage;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    Rigidbody2D rb; 

    public float speed = 5f;
    public float jumpForce = 10f; 
    private bool isClicked = false;

    Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        cam  = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    { 

        if (Input.GetMouseButtonDown(0) && !isClicked) 
        {
            isClicked = true; 
            Jump(); 
        }
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForceAtPosition(Vector2.up,Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); 
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (tag ==" Player")
        Debug.Log(other.gameObject.name + "ENTER");
    }

     private void OnCollisionStay2D(Collision2D other)
    {
        if (tag ==" Player")
        Debug.Log(other.gameObject.name + "STAY");
    }



}
