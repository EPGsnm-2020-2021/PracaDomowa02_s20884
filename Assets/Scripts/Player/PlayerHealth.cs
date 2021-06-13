using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public const int MAX_HEALTH = 10;
    public int curHealth;
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
        PlayerPrefs.GetInt("Points", 0);
    }
    public void Heal(int i)
    {
        curHealth += i;

        if (curHealth > MAX_HEALTH)
        {
            curHealth = MAX_HEALTH;
        }
        StartCoroutine(Healing());
    }
    public IEnumerator Healing()
    {
        animator.SetBool("Healing", true);
        yield return new WaitForSeconds(1);
        animator.SetBool("Healing", false);
    }
}

