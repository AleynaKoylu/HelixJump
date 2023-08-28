using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounds : MonoBehaviour
{
   

    GameObject gM;
    GameManager gameManager;

    float dst;
    

    GameObject ball;

    public bool Rotate;
    void Start()
    {
     

        gM = GameObject.FindGameObjectWithTag("GameController");
        gameManager = gM.GetComponent<GameManager>();
        ball = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnMouseDrag()
    {
        Rotate = true;
    }

    void Update()
    {
        dst = transform.position.y - ball.transform.position.y;
        if (dst >= 5f)
        {
            gameObject.SetActive(false);
        }
    }
   
    public void ChangeTransform()
    {
        if (transform.position.y == gameManager.gTransform.y)
        {
            
            transform.position = new Vector3(transform.position.x, gameManager.gTransform.y - 8*5, transform.position.z);
        }
        transform.rotation = new Quaternion(0, Random.Range(0, 360), 0, 2f);
    }
}
