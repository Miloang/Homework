using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public string objectTriggerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.tag == "Circle")
        Debug.Log(collision.gameObject.name + "Trigger ENTER");
    }

     private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Circle")
        Debug.Log(collision.gameObject.name + "Trigger STAY");
    }
}
