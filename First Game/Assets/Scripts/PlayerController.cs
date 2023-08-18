using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody;
    public float MovementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // Get Components
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    // Update is called at a fixed rate independent from fps
    private void FixedUpdate()
    {
        /*
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(new Vector2(3, 0));
        }
        */

        rigidbody.AddForce(new Vector2(Input.GetAxisRaw("Horizontal") * MovementSpeed, 0), ForceMode2D.Impulse);
        rigidbody.AddForce(new Vector2(0, Input.GetAxisRaw("Vertical") * (MovementSpeed * 0.1f)), ForceMode2D.Impulse);
    }
}
