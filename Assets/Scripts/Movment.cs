using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float runSpeed = 10.0f;
    public float dogeSpeed = 500f;

    private bool doDoge = false;

    public Animator animator;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            doDoge = true;
        }
        if (horizontal != 0)
        {
            animator.SetFloat("SquareMagnitude", 1);
        } 
        else if (vertical != 0)
        {
            animator.SetFloat("SquareMagnitude", 1);
        }
        else
        {
            animator.SetFloat("SquareMagnitude", 0);
        }
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        if (doDoge)
        {
            body.velocity = new Vector2(horizontal * dogeSpeed, vertical * dogeSpeed);
            doDoge = false;
        }
        else
        {
            body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        }


    }
}
