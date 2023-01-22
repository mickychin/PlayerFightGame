using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float force = 10f;
    public Rigidbody2D RB2d;

    void Start()
    {
        gameObject.transform.Rotate(90, 0, 0);
        RB2d.AddForce(transform.up * force, ForceMode2D.Impulse);  
    }

    void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        gameObject.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f) * Time.deltaTime;
    }
}
