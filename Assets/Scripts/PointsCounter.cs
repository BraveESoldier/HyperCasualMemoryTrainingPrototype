using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter: MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Text>().text = "Your points: " + SettingParameter.numberWins.ToString();
    }
}
