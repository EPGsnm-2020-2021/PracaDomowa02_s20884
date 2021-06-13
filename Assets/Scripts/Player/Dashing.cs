using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashing : MonoBehaviour
{
    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 0)
        {
            
            if(Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rb.velocity = Vector2.left * dashSpeed;
                animator.SetBool("Dashing", true);

            }
            else if(Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.RightArrow)){
                rb.velocity = Vector2.right * dashSpeed;
                animator.SetBool("Dashing", true);
            }
            else if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.UpArrow)){
                direction = 3;
                

            }
            else if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.DownArrow))
            {
                direction = 4;
               
            }

        } else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
                animator.SetBool("Dashing", false);
            }
            else
            {
                dashTime -= Time.deltaTime;
                

                if (direction == 1)
                {
                    
                    

                } else if (direction == 2){
                    
                    

                }
                 else if (direction == 3)
                 {
                rb.velocity = Vector2.up * dashSpeed;
                  

                }
                  else if (direction == 4)
                     {
                rb.velocity = Vector2.down * dashSpeed;
                    

                }
        }
        }
        
    }
}
