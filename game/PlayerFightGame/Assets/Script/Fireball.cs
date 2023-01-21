using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float force = 10f;
    public Rigidbody2D RB2d;
    // Start is called before the first frame update
    void Start()
    {
        RB2d.AddForce(transform.up * force, ForceMode2D.Impulse);  
    }

    // Update is called once per frame
    void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }
}
