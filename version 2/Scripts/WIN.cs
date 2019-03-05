using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIN : MonoBehaviour
{
    public GameObject destroyi;
    public float speed = 3.0f;
    public float speedup = 3.0f;
    public AudioSource wewon;
    void Start()
    {
        destroyi.SetActive(false);
    }
    public void up() {
        transform.Translate(Vector3.up * speedup);
    } public void rights() {
        transform.Translate(Vector3.right * speed);
    } public void lefts() {
        transform.Translate(Vector3.left * speed);
    }
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * speedup);
        }
       
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Ghost")
        {
            Debug.Log("WINNER");
            destroyi.SetActive(true);
            wewon.Play();
        }
    }
}
