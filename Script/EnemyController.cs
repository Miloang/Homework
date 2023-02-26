using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public string EnemyName;
    
    public int Health,Damage;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    public float jumpForce = 10f; 
    Rigidbody2D rb; 
    private bool isClicked = false;

    public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
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

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, verticalInput);
        transform.position += movement * speed * Time.deltaTime;
    }

    
    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); 
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (tag ==" Enemy")
        Debug.Log(other.gameObject.name + "ENTER");
    }

     private void OnCollisionStay2D(Collision2D other)
    {
        if (tag ==" Enemy")
        Debug.Log(other.gameObject.name + "STAY");
    }



}
