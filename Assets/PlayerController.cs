using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
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
