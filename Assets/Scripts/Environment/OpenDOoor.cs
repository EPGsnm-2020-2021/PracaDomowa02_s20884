using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDOoor : MonoBehaviour
{
    Animator animator;
    bool Open;

    // Start is called before the first frame update
    void Start()
    {
        Open = false;
        animator = GetComponent<Animator>();
    }

   

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Open = true;
            animator.SetBool("Open", true);
        }
       
    }

}
