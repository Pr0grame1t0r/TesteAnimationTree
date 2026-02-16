using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;

    public float jumpForce;

    public bool isGrounded;

    public float Direction;

    Rigidbody2D rb;

    Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (Input.GetAxis("Horizontal") < 0)
        {
            Direction = -1;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            Direction = 1;
        }
        anim.SetFloat("Direção", Direction);
    }

    void Movement()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Magnitude", movement.magnitude);
    }
}
