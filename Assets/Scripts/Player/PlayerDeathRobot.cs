using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathRobot : MonoBehaviour
{
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.Find("Player").GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            StartCoroutine(Death());
            

        }
    }
    public IEnumerator Death()
    {
        animator.SetBool("IsDead", true);
        yield return new WaitForSeconds(2);
        animator.SetBool("IsDead", false);
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
