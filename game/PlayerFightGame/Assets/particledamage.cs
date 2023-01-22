using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particledamage : MonoBehaviour
{
    private int playerLayer = 8; // the player layer you want to check against
    public List<ParticleCollisionEvent> collisionEvents;
    public ParticleSystem part;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
    }
    void OnParticleCollision(GameObject other)
    {
        
        Debug.Log("Collider");
        if (other.layer == playerLayer)
        {
            HP.HealthDetect = HP.HealthDetect - 1;
        }
    }
}
