using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTime2 : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(TextInActive());
        StartCoroutine(TextActive());
    }

    private IEnumerator TextActive()
    {
        yield return new WaitForSeconds(2);
        text.SetActive(false);

    }
    private IEnumerator TextInActive()
    {
       
        yield return new WaitForSeconds(2);
        text.SetActive(true);

    }
}
