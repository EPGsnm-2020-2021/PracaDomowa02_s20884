using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light swiatlo;

    // Start is called before the first frame update
    void Start()
    {
        swiatlo.gameObject.SetActive(false);
    }

 void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            swiatlo.gameObject.SetActive(true);
        }

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            swiatlo.gameObject.SetActive(false);
        }

    }
}
