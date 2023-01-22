using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [Header("Health")]
    public int Health = 100;
    public static int HealthDetect = 100;

    void Start()
    {
        HealthDetect = Health;
    }
    void Update()
    {
        Health = HealthDetect;
    }
}
