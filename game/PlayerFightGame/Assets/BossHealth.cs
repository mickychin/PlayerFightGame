using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public int BossMaxHealth;
    public int bossHealth;
    public healthbar healthbar;
    public GameObject DeathEffect;
    public GameObject DeadBody;
    // Start is called before the first frame update
    void Start()
    {
        bossHealth = BossMaxHealth;
        healthbar.SetMaxHealth(BossMaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(bossHealth < 1)
        {
            Instantiate(DeathEffect,transform.position, transform.rotation);
            Instantiate(DeadBody,transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int Damage)
    {
        bossHealth = bossHealth - Damage;
        healthbar.SetHealth(bossHealth);
    }
}
