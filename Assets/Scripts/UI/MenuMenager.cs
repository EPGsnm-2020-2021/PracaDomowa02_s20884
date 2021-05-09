using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMenager : MonoBehaviour
{
    public GameObject firstMenuView;
    public GameObject secondMenuView;


    public void ShowFirstMenu()
    {
        firstMenuView.SetActive(true);
        secondMenuView.SetActive(false);

    }
    public void ShowSecondMenu()
    {
        firstMenuView.SetActive(false);
        secondMenuView.SetActive(true);

    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        PlayerPrefs.GetInt("Points", 0);
    }

    public void CloseApp()
    {
        Application.Quit();
    }

}
