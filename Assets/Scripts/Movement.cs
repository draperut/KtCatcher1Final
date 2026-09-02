using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{

    [Header("Movement")]
    [Tooltip("Speed of movement")]
    public float speed;

    [Header("Platform Movement")]
    [Tooltip("Adjusts Movement for Platform Games")]
    public bool platformSettings = false;

    private Rigidbody2D rb;
    [Header("Jump Stremgth")]
    public float jumpStrength = 10f;

    public int jumps;

    void Awake()
    {   
        rb = GetComponent<Rigidbody2D>();    
    }



    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        RaycastHit2D hit = Physics2D.Raycast(transform.position + -Vector3.up * 2, -Vector2.up, 0.1f);
        if(hit.collider != null)
        {
            if(hit.collider.gameObject.CompareTag("Ground"))
            {
                print("Ground");
                jumps = 2;
            }
        }
        Debug.DrawRay(transform.position + -Vector3.up * 2, -Vector2.up * 0.1f, Color.white);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("jump pressed");
            if (jumps > 0)
            {
                // Apply an instantaneous upwards force
                rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
                jumps -= 1;
                //canJump = !checkGround;
            }
        }
        if(rb.velocity.y > 20)
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, 20);

        Vector3 movement = new Vector3(horizontal, 0);

        transform.position += movement * Time.deltaTime * speed;
    }
}

