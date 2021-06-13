using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTime : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(true);
        StartCoroutine(TextActive());
    }

    private IEnumerator TextActive()
    {
        yield return new WaitForSeconds(3);
        text.SetActive(false);

    }
}
