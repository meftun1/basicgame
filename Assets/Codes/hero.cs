using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
 
    Rigidbody2D rbChar;
    public float movementSpeed,jumpPower,maxSpeed;
    Animator animate;
    public bool onFloor;
    public int  maxHealth;
    private int health;
    void Start()
    {
        animate = GetComponent<Animator>();
        rbChar = GetComponent<Rigidbody2D>();
        health = maxHealth;
    }
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        
        animate.SetBool("onfloor",onFloor);
        animate.SetFloat("speed",Mathf.Abs(h));
        if (h>0)
        {
            transform.localScale = new Vector2(-1, 1);
            transform.Translate(h*movementSpeed*Time.deltaTime,0,0);
            
        }
        if (h<0)
        {
            transform.localScale = new Vector2(1,1);
            transform.Translate(h * movementSpeed * Time.deltaTime, 0, 0);
        }
        if (rbChar.velocity.x>maxSpeed)
        {
            rbChar.velocity = new Vector2(maxSpeed, rbChar.velocity.y);
        }
        if (rbChar.velocity.x < -maxSpeed)
        {
            rbChar.velocity = new Vector2(-maxSpeed, rbChar.velocity.y);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&onFloor)
        {
            rbChar.AddForce(Vector2.up*jumpPower);
        }
        if (health<0)
        {
            death();
        }
    }
    void death()
    {
        Application.LoadLevel(Application.loadedLevel);

    }
}
