using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] PrefabsForSpawn;
    static public float Delay = 0.5f;
    float DelayTimer = 0;
    private int rnd = 0;

    void Start()
    {
        //rnd = Random.Range(0, 4);

    }

    void Update()
    {
        DelayTimer += Time.deltaTime;
        if (DelayTimer >= Delay) {
            DelayTimer -= Delay;
            Spawn();
        }        
    }

    void Spawn()
    {
        rnd = Random.Range(0, 4);
        GameObject projectileGO = (GameObject)Instantiate(PrefabsForSpawn[rnd], transform.position, PrefabsForSpawn[rnd].transform.rotation);
    }
}
