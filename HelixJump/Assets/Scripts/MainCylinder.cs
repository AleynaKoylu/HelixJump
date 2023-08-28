using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCylinder : MonoBehaviour
{
    [SerializeField]
    GameObject Ball;

    float dist;

    
    void Update()
    {
        dist = Ball.transform.position.y - transform.position.y;
        if (dist <= -6)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 40f, transform.position.z);
        }
    }
}
