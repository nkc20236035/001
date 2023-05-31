using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContllore : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        Application.targetFrameRate = 60;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float y = Input.GetAxisRaw("Vertical");

        if ( y == 0)
        {
            anim.Play("Char");
        }

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(-0.1f, 0, 0);
            anim.Play("PlayerL");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate( 0 , -0.1f , 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate( 0.1f , 0 , 0);
            anim.Play("PlayerR");
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
