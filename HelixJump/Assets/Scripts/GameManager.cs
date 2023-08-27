using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Grounds = new List<GameObject>();
    void Start()
    {
        
            InvokeRepeating("ShowGrounds", 0, 2f);
        
    }

    void ShowGrounds()
    {
        int gValue = Random.Range(0, Grounds.Count);

            GameObject newg = Grounds[gValue];
            newg.SetActive(true);
            Grounds.RemoveAt(gValue);
            Grounds.Add(newg);

         
    }
    
    void Update()
    {
        
    }
}
