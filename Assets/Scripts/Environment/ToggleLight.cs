using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    private Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();

    }

   
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myLight.enabled = !myLight.enabled;
        }


    }
}
