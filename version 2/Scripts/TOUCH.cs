using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TOUCH : MonoBehaviour
{
    public string runname = "Player";
    public GameObject todestroy;
    public bool activateing = false;
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == runname)
        {
            todestroy.SetActive(activateing);
        }
    }
}
