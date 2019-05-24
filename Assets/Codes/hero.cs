using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
 
    Rigidbody2D rb_char;
    public float movementSpeed,jump,maxspeed;
    Animator animate;
    public bool onFloor;
    void Start()
    {
        animate = GetComponent<Animator>();
        rb_char = GetComponent<Rigidbody2D>();
        
    }
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        rb_char.AddForce(Vector3.right * h * movementSpeed);
        animate.SetBool("onfloor",onFloor);
        animate.SetFloat("speed",Mathf.Abs(h));
        if (h>0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        if (h<0)
        {
            transform.localScale = new Vector2(1,1);
        }
        if (rb_char.velocity.x>maxspeed)
        {
            rb_char.velocity = new Vector2(maxspeed,rb_char.velocity.y);
        }
        if (rb_char.velocity.x < -maxspeed)
        {
            rb_char.velocity = new Vector2(-maxspeed, rb_char.velocity.y);
        }
    }
    void Update()
    {

    }
}
