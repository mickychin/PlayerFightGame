using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [Header("Health")]
    public int MaxHealth = 100;
    public int Health = 100;
    public healthbar healthbar;
    public GameObject DeathEffect;

    void Start()
    {
        Health = MaxHealth;
    }
    public void TakeDamage(int Damage)
    {
        Health -= Damage;
        healthbar.SetHealth(Health);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BossAttack")
        {
            TakeDamage(1);
        }
    }
    void Update()
    {
        if(Health < 1)
        {
            Instantiate(DeathEffect,transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
