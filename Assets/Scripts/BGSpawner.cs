using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSpawner : MonoBehaviour
{
    public GameObject BG;
    public float spawnRate = 8;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnBG();
            timer = 0;
        }


    }
    void spawnBG()
    {
        float lowestPoint = transform.position.y;
        float highestPoint = transform.position.y;

        Instantiate(BG, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
