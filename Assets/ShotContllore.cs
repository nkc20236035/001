using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotContllore : MonoBehaviour
{
    GameObject play;
    GameObject ene;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0.1f, 0, 0);
        }
    }
}
