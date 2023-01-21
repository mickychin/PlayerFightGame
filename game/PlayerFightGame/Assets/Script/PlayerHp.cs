using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public Transform PlayerPos;
    public GameObject[] Heart;
    public int HP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerPos.position;
    }

    public void TakeDamage(int Damage)
    {
        HP = HP - Damage;
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        if(HP > Heart.Length)
        {
            return;
        }
        foreach (GameObject i in Heart)
        {
            i.SetActive(false);
        }
        for (int i = 0; i < HP; i++)
        {
            Heart[i].SetActive(true);
        }
    }
}
