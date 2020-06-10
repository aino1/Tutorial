using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    [SerializeField] float speed = 4;
     Rigidbody2D Rbody2D;
    void Start()
    {
        Rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Rbody2D.velocity = new Vector2(Rbody2D.velocity.y, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Rbody2D.velocity = new Vector2(Rbody2D.velocity.y, -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Rbody2D.velocity = new Vector2(Rbody2D.velocity.x, speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Rbody2D.velocity = new Vector2(Rbody2D.velocity.x, -speed);
        }

    }
}
