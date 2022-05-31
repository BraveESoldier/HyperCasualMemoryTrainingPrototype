using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowControl : MonoBehaviour
{
    [Header("Set in Inspector")]
    //private float Speed = 5f;
    private Rigidbody rb;

    [SerializeField]
    private SpawnFactors SF;
    public NumberSpawner NS;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();      
    }

    private void FixedUpdate()
    {
        MoveArrow();
        if(SettingParameter.Win == 1 | SettingParameter.Win == 2)
        {
            SettingParameter.Speed = 0;
        }
    }

    private void MoveArrow()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(moveHorizontal, 0.0f, 1f);
        rb.AddForce(move * SettingParameter.Speed);

    }

    private void OnTriggerExit(Collider Coll)
    {
        switch (Coll.gameObject.tag)
        {
            case "Left":
                SettingParameter.SideLeft = true;
                break;
            case "Right":
                SettingParameter.SideRight = true;
                break;
        }
        SettingParameter.spawnProduced = false;
        Debug.Log(SettingParameter.numberCheck); 
    } 

}
