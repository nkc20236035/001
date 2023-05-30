using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContllore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate( 0 , -0.1f , 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate( 0.1f , 0 , 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate( 0 , 0.1f , 0);
        }

        if(transform.position.x > 11)
        {
            transform.position = new Vector2 (11, transform.position.y);
        }
        if (transform.position.x < -11)
        {
            transform.position = new Vector2(-11, transform.position.y);
        }
        if (transform.position.y > 5)
        {
            transform.position = new Vector2(transform.position.x, 5);
        }
        if (transform.position.y < -5)
        {
            transform.position = new Vector2(transform.position.x, -5);
        }
    }
}
