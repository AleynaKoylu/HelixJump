using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRotate : MonoBehaviour
{
    Vector3 firstPos, lastPos;
    float angelY;

    [SerializeField]
    float rotateSpeed;
    
    void Start()
    {
        
    }


    
 
     void Update()
     {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            firstPos = pos;
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            lastPos = pos;
            angelY += firstPos.y - lastPos.y;
            transform.rotation = Quaternion.Euler(0, angelY * rotateSpeed, 0);
            firstPos = lastPos;
            
        }
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            firstPos = pos;
        }
        if (Input.GetMouseButton(1))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            lastPos = pos;
            angelY += lastPos.y-firstPos.y;
            transform.rotation = Quaternion.Euler(0, angelY * rotateSpeed, 0);
            firstPos = lastPos;

        }


    }
}
