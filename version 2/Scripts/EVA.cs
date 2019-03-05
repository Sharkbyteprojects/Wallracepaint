using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EVA : MonoBehaviour
{
    public float speed = 3.0f;
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            transform.Translate(Vector3.down * speed);
        }
    }
}
