using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour
{
    [Header("Keys")]
    public KeyCode LeftRotationkey;
    public KeyCode RightRotationkey;

    [Header("Rotations")]
    public float minRotation = -45f;
    public float maxRotation = 45f;

    void Update()
    {
        if (Input.GetKey(LeftRotationkey))
        {
            float currentRotation = gameObject.transform.rotation.z;
            currentRotation = Mathf.Clamp(currentRotation - 0.01f, minRotation, maxRotation);
            gameObject.transform.rotation = new Quaternion(0,0,currentRotation,1);
        }
        if (Input.GetKey(RightRotationkey))
        {
            float currentRotation = gameObject.transform.rotation.z;
            currentRotation = Mathf.Clamp(currentRotation + 0.01f, minRotation, maxRotation);
            gameObject.transform.rotation = new Quaternion(0,0,currentRotation,1);
        }
    }
}
