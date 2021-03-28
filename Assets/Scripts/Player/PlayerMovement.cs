using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float jumpForce = 400;
    

    private Rigidbody2D rb;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        float xDisplacement = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            isGrounded = false;
        }


        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20;
        }
        else
        {
            speed = 10;
        }
     }
    

    void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;

        if ( col.gameObject.name.Equals ("moving platform"))
        {
            this.transform.parent = col.transform;
        }

    }

    void OnCollisionExit2D(Collision2D col)
    {
        isGrounded = true;

        if (col.gameObject.name.Equals("moving platform"))
        {
            this.transform.parent = null;
        }

    }

}
