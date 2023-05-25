using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneletor : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float span = 0.5f;
    float delta = 0;


    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(EnemyPrefab);
            int px = Random.Range(-4, 4);
            go.transform.position = new Vector3(13, px, 0);
        }
    }
}
