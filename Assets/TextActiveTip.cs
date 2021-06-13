using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextActiveTip : MonoBehaviour
{
    public GameObject textt;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("tak");
            textt.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            textt.SetActive(false);
        }
    }
}
