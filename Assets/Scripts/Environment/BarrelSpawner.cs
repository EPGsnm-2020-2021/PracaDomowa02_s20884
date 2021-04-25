using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawner : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        StartCoroutine(Shoot());

    }

    void Update()
    {
        
    }

    public IEnumerator Shoot()
    {
        Instantiate(prefab, transform.position, transform.rotation);

        yield return new WaitForSeconds(2);

        StartCoroutine(Shoot());
    }
}
