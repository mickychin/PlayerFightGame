using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Boss;
    public Vector2 lookDir;
    public float distancbetwBoss;
    public float MoveSPeed;

    [Header("Bullet")]
    public GameObject bullet;
    public Transform startingPoint;
    public float BulletSpeed;
    public float fireRate;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("PewPew", fireRate);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(startingPoint.up);
        lookAtBoss();
        distancbetwBoss = Vector2.Distance(transform.position, Boss.transform.position);
        if (distancbetwBoss > 6)
        {
            transform.position += startingPoint.up * MoveSPeed;
        }
    }

    void lookAtBoss()
    {
        lookDir = Boss.transform.position - transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void PewPew()
    {
        GameObject bullets = Instantiate(bullet, startingPoint.position, startingPoint.rotation);
        Rigidbody2D bulRB = bullets.GetComponent<Rigidbody2D>();
        bulRB.AddForce(startingPoint.up * BulletSpeed, ForceMode2D.Impulse);
        bullet.GetComponent<Rigidbody2D>();
        Invoke("PewPew", fireRate);
    }
}
