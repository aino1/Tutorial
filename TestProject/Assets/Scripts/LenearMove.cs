using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LenearMove : MonoBehaviour
{
    
    Rigidbody2D rbody2D;
    [SerializeField]Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        rbody2D.velocity = direction;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
