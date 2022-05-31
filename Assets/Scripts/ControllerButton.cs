using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerButton : MonoBehaviour
{
    public Animator loseAnim;
    public Animator winAnim;

    [SerializeField] public NumberSpawner NS;

    private void FixedUpdate()
    {
        if(SettingParameter.Win == 1)
        {
            winAnim.SetBool("WinMoment", true);
        }
        if(SettingParameter.Win == 2)
        {
            loseAnim.SetBool("LoseMoment", true);
        }
    }

    private void Replay()
    {
        SceneManager.LoadScene("Scene_0");
        NS.ÑleanFields();
        ÑleanFieldsButton();
    }

    private void ExitToMenu()
    {
        SceneManager.LoadScene("Scene_MenuStart");
        NS.ÑleanFields();
        ÑleanFieldsButton();
    }

    private void ClickOnWin()
    {
        SettingParameter.numberWins++;
        SceneManager.LoadScene("Scene_MenuStart");
        NS.ÑleanFields();
        ÑleanFieldsButton();
    }

    private void ClickOnLose()
    {
        SettingParameter.numberWins--;
        SceneManager.LoadScene("Scene_MenuStart");
        NS.ÑleanFields();
        ÑleanFieldsButton();
    }

    private void ÑleanFieldsButton()
    {
        loseAnim.SetBool("LoseMoment", false);
        winAnim.SetBool("WinMoment", false);
        SettingParameter.WinSide = "";
        SettingParameter.numberCheck = 0;
        SettingParameter.Win = 0;
    }
}
