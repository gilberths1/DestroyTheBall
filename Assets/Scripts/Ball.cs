using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public GameObject ballPrefab;
    Rigidbody2D rb;

    public float startForce = 15f; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);    
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Blade")
        {   
            Vector3 direction = (col.transform.position - transform.position) .normalized;
            Quaternion rotation = Quaternion.LookRotation(direction);
            GameObject slicedBall = Instantiate(ballPrefab, transform.position, rotation); 
            Destroy(slicedBall, 3f);
            Destroy(gameObject);
        }
    }
}
