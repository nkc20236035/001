using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotDirector : MonoBehaviour
{
    public GameObject shotPrefab;
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("MyChar_0");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(shotPrefab);
            go.transform.position = new Vector3(player.transform.position.x,player.transform.position.y,player.transform.position.z);
        }
    }
}