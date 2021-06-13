using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathRobot : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("IsDead", true);
            StartCoroutine(Death());
            Destroy(collision.gameObject);
            animator.SetBool("IsDead",false);
        }
    }
    public IEnumerator Death()
    {
        yield return new WaitForSeconds(2);
    }
}
