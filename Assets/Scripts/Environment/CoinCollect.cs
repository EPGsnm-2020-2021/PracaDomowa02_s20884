using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
   public Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        animator.ResetTrigger("CoinGet");
        
    }

    void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            animator.SetTrigger("CoinGet");
        }
    }
}
 