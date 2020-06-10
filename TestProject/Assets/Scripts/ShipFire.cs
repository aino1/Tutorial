using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFire : MonoBehaviour
{
    [SerializeField] GameObject attack = null;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.F))
        {
            Instantiate(attack, transform.position, transform.rotation);
        }
        
    }
}
