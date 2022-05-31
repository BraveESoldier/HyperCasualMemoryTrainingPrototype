using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFactors : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject factorsPrefab;
    public GameObject FactorStartPosition;
    public GameObject Factor;
    public Vector3 increasingRange = new Vector3(0, 0, 40);

    [SerializeField]
    private ArrowControl AC;
    public NumberSpawner NS;


    private void Awake()
    {
        Factor = Instantiate(factorsPrefab, FactorStartPosition.transform.position, Quaternion.identity);
    }

    private void SpawnFactor()
    {
        if(SettingParameter.numberCheck != 9)
        {
            increasingRange = increasingRange + new Vector3(0, 0, 30);
            Destroyer();
            Factor = Instantiate(factorsPrefab, FactorStartPosition.transform.position + increasingRange, Quaternion.identity);
            SettingParameter.spawnProduced = true;
            SettingParameter.numberCheck = SettingParameter.numberCheck + 1;
        }
    }

    private void Destroyer()
    {
        Destroy(Factor);
    }

    private void FixedUpdate()
    {
        if (SettingParameter.spawnProduced == false)
        {
            SpawnFactor();
        }
    }
}
