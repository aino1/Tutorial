using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBang : MonoBehaviour
{
    [SerializeField] GameObject droppedBoom = null;
    [SerializeField] int  life = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        life--;
        if (life <= 0)
        {
            if (droppedBoom)
            {
                Instantiate(droppedBoom, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }

}
