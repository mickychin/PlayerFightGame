using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Boss;
    public Vector2 lookDir;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lookAtBoss();
    }

    void lookAtBoss()
    {
        lookDir = Boss.transform.position - transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x);
    }
}
