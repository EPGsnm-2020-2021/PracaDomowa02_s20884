using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearPlat : MonoBehaviour
{
    IEnumerator OnCollisionEnter2D(Collision2D coll)
    {

        yield return new WaitForSeconds(1);
        Destroy(gameObject);

    }
}
