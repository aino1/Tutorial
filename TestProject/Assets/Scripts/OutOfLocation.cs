using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfLocation : MonoBehaviour
{
    [SerializeField] float LeftLimit;
    [SerializeField] float RightLimit;
    [SerializeField] float UpLimit;
    [SerializeField] float DownLimit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < LeftLimit)
        {
            transform.position = new Vector3(RightLimit, Random.Range(DownLimit, UpLimit), transform.position.z);
        }
        
    }
}
