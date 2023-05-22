using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingieSpawner : MonoBehaviour
{
    public GameObject[] things;
    public float range = 50.0f;
    public int amount = 2000;


    void Start()
    {
        for(int i = 0; i < amount; i++)
        {
            GameObject prefab = things[Random.Range(0, things.Length)];
            Instantiate(
                prefab, 
                transform.position + new Vector3(
                    Random.Range(-range, range),
                    Random.Range(-range, range)*0.1f,
                    Random.Range(-range, range)
                ), 
                Random.rotation
            );
        }
    }
}
