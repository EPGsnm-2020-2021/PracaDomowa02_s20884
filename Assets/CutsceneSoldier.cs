using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneSoldier : MonoBehaviour
{
    public GameObject soldier;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Cutscene());
    }

    private IEnumerator Cutscene()
    {
        yield return new WaitForSeconds(3);
        Destroy(soldier.gameObject);
    }
}
