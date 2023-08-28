using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    
    [SerializeField]
    GameObject Ball;

    float distance;
    void Start()
    {

        distance = transform.position.y - Ball.transform.position.y;
    }

    
    void Update()
    {
        float dst = transform.position.y - Ball.transform.position.y;
        if (dst > distance)
        {
            transform.position = new Vector3(transform.position.x, Ball.transform.position.y+distance, transform.position.z);
        }
        
    }
}
