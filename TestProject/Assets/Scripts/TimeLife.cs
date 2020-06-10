using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TimeLife : MonoBehaviour
{
    [SerializeField] float time = 3;
    void Start()
    {
        Destroy(gameObject, time);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
