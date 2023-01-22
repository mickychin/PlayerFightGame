using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    Rigidbody2D RB2d;
    // Start is called before the first frame update
    void Start()
    {
        RB2d = GetComponent<Rigidbody2D>();
        RB2d.AddForce(transform.up * 10, ForceMode2D.Impulse); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
