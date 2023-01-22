using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particledamage : MonoBehaviour
{
    private int playerLayer = 8; // the player layer you want to check against

    void OnParticleCollision(GameObject other)
    {
        if (other.layer == playerLayer)
        {
            HP.HealthDetect = HP.HealthDetect - 1;
        }
    }
}
