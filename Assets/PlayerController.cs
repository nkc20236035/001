using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-0.1f, 0, 0);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.1f, 0, 0);
        }

        if(transform.position.x < -11)
        {
            gameObject.transform.position = new Vector3(-11, gameObject.transform.position.y);
        }
        if (transform.position.x > 11)
        {
            gameObject.transform.position = new Vector3(11, gameObject.transform.position.y);
        }
        if (transform.position.y < -5)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,-5);
        }
        if (transform.position.y > 5)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 5);
        }


    }
}
