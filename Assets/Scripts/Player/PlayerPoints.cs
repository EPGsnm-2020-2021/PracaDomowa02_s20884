using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public int points;

    void Start()
    {
        points = 0;

        if(PlayerPrefs.HasKey("Points"))
        {
            points = PlayerPrefs.GetInt("Points");
        }
        UpdateHUD();
        if(points >= 10)
        {
            points = 0;
        }
    }
    
    public void Points(int Points)
    {
        points += Points;

        UpdateHUD();

    }

    public void UpdateHUD()
    {
        GameObject.Find("CanvasHUD").GetComponent<HUDManager>().SetPlayerPoints(points);
    }
}
