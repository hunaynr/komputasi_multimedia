using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigidbody2d;
    public bool facingRight = true;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        rigidbody2d.velocity = new Vector2(speed * move, rigidbody2d.velocity.y);
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
