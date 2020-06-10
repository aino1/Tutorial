using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WaveMove: MonoBehaviour
{
    Rigidbody2D rbody2D;
    [SerializeField] float power = -1;
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody2D.velocity = new Vector2(rbody2D.velocity.x, power);
        power = -power;
        
    }
}
