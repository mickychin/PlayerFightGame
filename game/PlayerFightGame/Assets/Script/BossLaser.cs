using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLaser : MonoBehaviour
{
    [SerializeField] private float defDistanceRay = 100; //Default Distance Laser
    public Transform firePoint;
    public LineRenderer linerender;
    Transform myTranform;
    private void Awake()
    {
        myTranform = GetComponent<Transform>();
    }

    private void Update()
    {
        ShootLaser();
    }

    void ShootLaser()
    {
        if(Physics2D.Raycast(myTranform.position, transform.right))
        {
            RaycastHit2D _hit = Physics2D.Raycast(myTranform.position, transform.right);
            if (_hit.collider.CompareTag("Player") && FindObjectOfType<Player>().invulnerable == false)
            {
                FindObjectOfType<Player>().StartCoroutine("TakeDamage");
            }
            Draw2DRay(firePoint.position, _hit.point);
        }
        else
        {
            Draw2DRay(firePoint.position, firePoint.transform.right * defDistanceRay);
        }
    }

    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        linerender.SetPosition(0, startPos);
        linerender.SetPosition(1, endPos);
    }
}
