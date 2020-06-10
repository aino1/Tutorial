using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWawe : MonoBehaviour
{
    [SerializeField] int  repeat = 0;


    void Start()
    {
        ///InvokeRepeating("SpawnWaveEnemy",timeBeforeStart,)
    }

    void SpawnWaveEnemy()
    {
        if(repeat > 0)
        {
            repeat--;
        }
    }
}
