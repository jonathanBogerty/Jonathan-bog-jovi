using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedy = 4f;
    public float speedx = 4f;
    private Rigidbody2D rb;
    float dirX;
    bool bottom = false;
    public Transform player;
    float LastYPosition;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * speedy, rb.velocity.y);


        if (player.position.y < -5f) 
        {
            bottom = true;
        }
        else
        {
            bottom = false;
        }
        if (bottom == false && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, speedx);
        }
        if (bottom == true && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, -speedx/2);
        }

        if (LastYPosition < -5f && player.position.y > -5f)
        {
            Flip(7);
        }
        if (LastYPosition > -5f && player.position.y < -5f)
        {
            Flip(-7);
        }
        LastYPosition = rb.position.y;

    }
    void Flip(int direction)
    {
        rb.velocity = new Vector2(0, direction);
    }
}