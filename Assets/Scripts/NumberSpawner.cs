using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSpawner : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject NumberCollider1;
    public GameObject NumberCollider2;


    private int MainNumberLeft;
    private int MainNumberRight;
    static private int MainNumberTop;
    static private int PastMainNumberLeft;
    static private int PastMainNumberRight;


    private void Awake()
    {
        SpawnNumber();
    }

    private void SpawnNumber()
    {
        switch (SettingParameter.numberCheck)
        {
            case 9:
                WinOr();
                SettingParameter.spawnProduced = true;
                break;
            default:
                //Degug.Log("R " + SettingParameter.SideRight);
                //Debug.Log("L" + SettingParameter.SideLeft);
                MainNumberLeft = Random.Range(1, SettingParameter.randomMult);
                MainNumberRight = Random.Range(1, SettingParameter.randomMult);
                NumberCollider1.GetComponent<TextMesh>().text = "+" + MainNumberLeft.ToString();
                NumberCollider2.GetComponent<TextMesh>().text = "+" + MainNumberRight.ToString();
                Count();
                if (SettingParameter.numberCheck == 8)
                {
                    MainResult();
                }
                break;
        }
    }
    

    private void Count()
    {
        if (SettingParameter.SideRight == true)
        {
            MainNumberTop = MainNumberTop + PastMainNumberRight;
            Debug.Log(" MainTOPR " + MainNumberTop);
            SettingParameter.SideRight = false;
        }
        if (SettingParameter.SideLeft == true)
        {
            MainNumberTop = MainNumberTop + PastMainNumberLeft;
            Debug.Log(" MainTOPL " + MainNumberTop);
            SettingParameter.SideLeft = false;
        }
        PastMainNumberLeft = MainNumberLeft;
        PastMainNumberRight = MainNumberRight;
    }

    private void MainResult()
    {
        int randomMulti = Random.Range(-100, 100);
        int randomMoment = Random.Range(0, 2);
        switch (randomMoment)
        {
            case 0:

                int rightRandom = MainNumberTop + randomMulti;
                NumberCollider1.GetComponent<TextMesh>().text = MainNumberTop.ToString();
                NumberCollider2.GetComponent<TextMesh>().text = rightRandom.ToString();
                SettingParameter.WinSide = "Left";
                break;
            case 1:
                int leftRandom = MainNumberTop + randomMulti;
                NumberCollider1.GetComponent<TextMesh>().text = leftRandom.ToString();
                NumberCollider2.GetComponent<TextMesh>().text = MainNumberTop.ToString();
                SettingParameter.WinSide = "Right";
                break;
        }
    }

    private void WinOr()
    {
        switch (SettingParameter.WinSide)
        {
            case "Right":
                if(SettingParameter.SideRight == true)
                {
                    SettingParameter.Win = 1;
                    Debug.Log("You Win");
                }
                else
                {
                    SettingParameter.Win = 2;
                    Debug.Log("You Lose");
                }
                ÑleanFields();
                break;
            case "Left":
                if (SettingParameter.SideLeft == true)
                {
                    SettingParameter.Win = 1;
                    Debug.Log("You Win");
                }
                else
                {
                    SettingParameter.Win = 2;
                    Debug.Log("You Lose");
                }
                ÑleanFields();
                break;

        }
    }

    private void FixedUpdate()
    {
        if (SettingParameter.spawnProduced == false)
        {
            if(SettingParameter.numberCheck <= 9)
            {
                SpawnNumber();
            }

        }
    }

    private void Update()
    {
        if(SettingParameter.spawnProduced == false)
        {
            print("spawnProduced == false");
        }
    }

    public void ÑleanFields()
    {
        MainNumberLeft = 0;
        MainNumberRight = 0;
        MainNumberTop = 0;
        PastMainNumberLeft = 0;
        PastMainNumberRight = 0;
    }
}

