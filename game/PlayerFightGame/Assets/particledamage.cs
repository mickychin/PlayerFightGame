using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particledamage : MonoBehaviour
{
    //private int playerLayer = 8; // the player layer you want to check against

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("YES");
        if(other.tag == "BossAttack")
        {
            FindObjectOfType<HP>().TakeDamage(1);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "BossAttack")
        {
            FindObjectOfType<HP>().TakeDamage(30);
        }
    }
}
