using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public bool canRotate = true;
    public bool canMove = true;
    public float rotateSpeed;
    public float speed;
    Rigidbody2D rb;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove == true)
        {
            float horizontal = 0f;
            float vertical = 0f;
            if (Input.GetKey(KeyCode.A)) horizontal = -1f;
            if (Input.GetKey(KeyCode.D)) horizontal = 1f;
            if (Input.GetKey(KeyCode.W)) vertical = 1f;
            if (Input.GetKey(KeyCode.S)) vertical = -1f;

            Vector3 moveDir = new Vector3(horizontal, vertical).normalized;
            rb.velocity = moveDir * speed;
            if(horizontal != 0 || vertical != 0)
            {
                animator.SetBool("walk", true);
            }
            else
            {
                animator.SetBool("walk", false);
            }
        }
        if(canRotate == true)
        {
            float rotate = 0f;
            if (Input.GetKey(KeyCode.LeftArrow)) rotate = 1f;
            if (Input.GetKey(KeyCode.RightArrow)) rotate = -1f;

            rb.rotation += rotate * rotateSpeed;
        }
        //transform.position += moveDir * speed * Time.deltaTime;

    }
}
