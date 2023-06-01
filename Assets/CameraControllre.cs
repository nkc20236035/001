using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllre : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.01f,0,0);
        if (transform.position.x >48)
        {
            transform.position = new Vector3(0, 0, -10);
        }
    }
}
