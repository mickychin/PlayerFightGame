﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public int BossMaxHealth;
    public int bossHealth;
    public healthbar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        bossHealth = BossMaxHealth;
        healthbar.SetMaxHealth(BossMaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TakeDamage(int Damage)
    {
        bossHealth = bossHealth - Damage;
        healthbar.SetHealth(bossHealth);
    }
}