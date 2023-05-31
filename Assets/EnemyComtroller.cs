using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyComtroller : MonoBehaviour
{
    GameObject player;
    GameObject shot;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
        this.shot = GameObject.Find("Shot");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f, 0, 0);

        if(transform.position.x <-13)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 p3 = this.shot.transform.position;
        Vector2 dir = p1 - p2;
        Vector2 dir2 = p1 - p3;
        float d = dir.magnitude;
        float d2 = dir2.magnitude;
        float r1 = 0.1f;
        float r2 = 0.5f;
        float r3 = 0.2f;

        if (d < r1 + r2 )
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseTime();
            Destroy (gameObject);
        }

        if(d2 < r1 + r3 )
        {
            Destroy (gameObject);
        }
    }
}
