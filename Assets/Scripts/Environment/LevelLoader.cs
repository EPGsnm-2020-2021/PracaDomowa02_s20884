using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string sceneNameToLoad;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            int points = GameObject.Find("Player").GetComponent<PlayerPoints>().points;
            PlayerPrefs.SetInt("Points", points);
            SceneManager.LoadScene(sceneNameToLoad);
            

        }

    }


}
