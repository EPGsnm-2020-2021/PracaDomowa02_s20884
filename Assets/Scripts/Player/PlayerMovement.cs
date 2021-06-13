using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float jumpForce = 400;

    public GameObject player;
    private Rigidbody2D rb;
    public bool isGrounded;
    private Animator animator;
    public float Dist;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetBool("IsDead", false);
    }

    // Update is called once per frame
    void Update()
    {
        float xDisplacement = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce));

        }


        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20;
        }
        else
        {
            speed = 10;
        }

        Debug.DrawLine(transform.position, transform.position + new Vector3(0, -Dist, 0), Color.green);

        var Hits2D = Physics2D.RaycastAll(transform.position, -transform.up, Dist);
        foreach (var item in Hits2D)
        {
            if (item.transform.tag == "Ground")
            {
                isGrounded = true;
                animator.SetBool("IsJumping", false);
            }
            else if (item.transform.tag == "Death")
            {
                animator.SetBool("IsDead", true);
            }

            else
            {
                isGrounded = false;
                animator.SetBool("IsJumping", true);
            }
            if (item.transform.tag == "Platform")
            {
                isGrounded = true;
                animator.SetBool("IsJumping", false);

            }
        }



        void OnCollisionEnter2D(Collision2D collider)
        {
            isGrounded = true;

            if (collider.gameObject.CompareTag("Platform") && isGrounded)
            {
                player.transform.parent = collider.gameObject.transform;

            }

        }

        void OnCollisionExit2D(Collision2D collider)
        {
            isGrounded = false;

            if (collider.gameObject.CompareTag("Platform"))
            {
                player.transform.parent = null;
            }

        }

    }
}
