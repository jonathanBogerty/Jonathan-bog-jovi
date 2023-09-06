using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GravityScaler : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    void Start()
    {

    }

    void Update()
    {
        if (player.position.y < -5f)
        {
            Physics2D.gravity = new Vector2(0f, 9.8f);

        }
        else
        {
            Physics2D.gravity = new Vector2(0f, -9.8f);

        }
         
    }
}   