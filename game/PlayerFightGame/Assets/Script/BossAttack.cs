using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    [Header("Fireball")]
    public KeyCode FireballKey;
    public GameObject Fireball;
    bool CanFireBall = true;

    [Header("Firebreath")]
    public KeyCode FirebreathKey;
    public GameObject Firebreath;
    bool canBreath = true;

    [Header("Firebeam")]
    public KeyCode FirebeamKey;
    public GameObject FirebeamCharge;
    public GameObject Firebeam;
    bool canfireBeam = true;

    void Update()
    {
        //Debug.Log(this.gameObject.name);
        if(Input.GetKeyDown(FireballKey) && CanFireBall)
        {
            StartCoroutine(ShootFireBall());
            Instantiate(Fireball,transform.position, transform.rotation);
        }
        if(Input.GetKeyDown(FirebreathKey) && canBreath)
        {
            Instantiate(Firebreath,transform.position, transform.rotation, gameObject.transform);
            StartCoroutine(ShootBreath());
        }
        if(Input.GetKeyDown(FirebeamKey) && canfireBeam)
        {
            Instantiate(FirebeamCharge,transform.position, transform.rotation, gameObject.transform);
            StartCoroutine(FirebeamCharging());
        }
    }

    IEnumerator ShootFireBall()
    {
        CanFireBall = false;
        yield return new WaitForSeconds(0.5f);
        CanFireBall = true;
    }

    IEnumerator ShootBreath()
    {
        canBreath = false;
        yield return new WaitForSeconds(10f);
        canBreath = true;
    }

    IEnumerator FirebeamCharging()
    {
        canfireBeam = false;
        yield return new WaitForSeconds(2); // wait for 2 seconds
        Instantiate(Firebeam,transform.position, transform.rotation, gameObject.transform);
        yield return new WaitForSeconds(10);
        canfireBeam = true;
    }
}
