using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
   public Animator animator;
    public int points;
    

    // Start is called before the first frame update
    void Start()
    {
        animator.ResetTrigger("CoinGet");
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            
            collision.gameObject.GetComponent<PlayerPoints>().Points(points);
            Destroy(animator.gameObject);
        }
    }
}
 