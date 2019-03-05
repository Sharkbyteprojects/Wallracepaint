using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EVAt : MonoBehaviour
{
    public float speed = 0.03f;
    public bool up = false;
    void Start()
    {
        up = false;
    }
    void Update() {
        if (up == true) {
            transform.Translate(Vector3.up * speed);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            up = true;
        }
        if (coll.gameObject.name == "Grid") {
            up = false;
        }
    }
}
