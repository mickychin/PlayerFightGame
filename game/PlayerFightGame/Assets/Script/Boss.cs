using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float rotateSpeed;
    public float speed;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotate = 0f;
        float horizontal = 0f;
        float vertical = 0f;
        if (Input.GetKey(KeyCode.LeftArrow)) rotate = 1f;
        if (Input.GetKey(KeyCode.RightArrow)) rotate = -1f;
        if (Input.GetKey(KeyCode.A)) horizontal = -1f;
        if (Input.GetKey(KeyCode.D)) horizontal = 1f;
        if (Input.GetKey(KeyCode.W)) vertical = 1f;
        if (Input.GetKey(KeyCode.S)) vertical = -1f;

        rb.rotation += rotate * rotateSpeed;
        Vector3 moveDir = new Vector3(horizontal, vertical).normalized;
        rb.velocity = moveDir * speed;
        //transform.position += moveDir * speed * Time.deltaTime;

    }
}
