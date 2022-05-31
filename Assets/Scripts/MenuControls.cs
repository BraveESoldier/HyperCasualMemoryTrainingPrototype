using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayPressedEasy()
    {
        SettingParameter.DifficaltyLevel = false;
        SettingParameter.randomMult = 10;
        SettingParameter.Speed = 4;
        SceneManager.LoadScene("Scene_0");
    }

    public void PlayPressedMiddle()
    {
        SettingParameter.DifficaltyLevel = false;
        SettingParameter.Speed = 5;
        SettingParameter.randomMult = 20;
        SceneManager.LoadScene("Scene_0"); 
    }

    public void PlayPressedHard()
    {
        SettingParameter.DifficaltyLevel = false;
        SettingParameter.Speed = 6;
        SettingParameter.randomMult = 50;
        SceneManager.LoadScene("Scene_0");
    }

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit presset");
    }

    private void FixedUpdate()
    {
        switch (SettingParameter.numberWins)
        {
            case 10:
                SceneManager.LoadScene("Scene_1_Win");
                SettingParameter.numberWins = 0;
                break;
        }
    }
}
