using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Text playerPoints;


    public void SetPlayerPoints(int points)
    {
        playerPoints.text = $": {points}";
    }
}
