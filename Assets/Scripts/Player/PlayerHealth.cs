using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
   
    
    float curHealth;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        curHealth = 10;
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDeath();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Kałuza")
        {
            curHealth = 0;
        }
    }
   void PlayerDeath()
    {
        if (curHealth <= 0)
        {
            animator.SetBool("IsDead", true);
            
        }
    }
    private void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
