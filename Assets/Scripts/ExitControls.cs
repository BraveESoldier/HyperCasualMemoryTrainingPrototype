using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitControls : MonoBehaviour
{

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit presset");
    }
}
