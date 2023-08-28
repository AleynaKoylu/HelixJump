using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    float jumpValue;

    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    GameObject defatPanel;



    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        gameObject.transform.position = new Vector3(0, transform.position.y, -2f);

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
              
                    rb.velocity = Vector3.zero;
                    rb.velocity = Vector3.up * jumpValue;
                
            

        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            rb.velocity = Vector3.zero;
            defatPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Score"))
        {

            gameManager.Score();
            
        }
        
    }
   
}
