using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float walkSpeed; 
    public bool mustPatrol;
    private bool mustTurn;
    public Rigidbody2D rb;
    public Transform groundCheckPos;
    public LayerMask Ground;
    public Collider2D bodyCollider;
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        mustPatrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (mustPatrol)
        {
            AIPatrol();
        } else
        {
            animator.SetBool("Patroling", false);
        }
    }
    private void FixedUpdate()
    {
        if (mustPatrol)
        {
            mustTurn = !Physics2D.OverlapCircle(groundCheckPos.position, 0.1f, Ground);
        }
    }

    void AIPatrol()
    {
        if (mustTurn || bodyCollider.IsTouchingLayers(Ground))
        {
            Flip();
        }
        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
        animator.SetBool("Patroling", true);
    }
    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
        mustPatrol = true;
    }
}

