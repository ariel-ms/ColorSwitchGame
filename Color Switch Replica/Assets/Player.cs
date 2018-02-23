using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float jumpForce = 10f;
    public Rigidbody2D rb;

    public string currentColor;

    private void Start()
    {
        SetRandomColor();    
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        //if (col.tag == "")
    }

    void SetRandomColor()
    {
        int index = Random.Range(0,3);
        switch(index)
        {
            case 0:
                currentColor = "Cyan";
                break;
            case 1:
                currentColor = "Yellow";
                break;
            case 2:
                currentColor = "Magenta";
                break;
            case 3:
                currentColor = "Pink";
                break;
        }
    }
}
