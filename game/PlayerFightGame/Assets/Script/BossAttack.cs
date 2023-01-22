using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    [Header("Fireball")]
    public KeyCode FireballKey;
    public GameObject Fireball;

    [Header("Firebreath")]
    public KeyCode FirebreathKey;
    public GameObject Firebreath;

    [Header("Firebeam")]
    public KeyCode FirebeamKey;
    public GameObject Firebeam;

    void Update()
    {
        if(Input.GetKeyDown(FireballKey))
        {
            Instantiate(Fireball,transform.position, transform.rotation);
        }
        if(Input.GetKeyDown(FirebreathKey))
        {
            Instantiate(Firebreath,transform.position, transform.rotation, gameObject.transform);
        }
        if(Input.GetKeyDown(FirebeamKey))
        {
            Instantiate(Firebeam,transform.position, transform.rotation, gameObject.transform);
        }
    }
}
