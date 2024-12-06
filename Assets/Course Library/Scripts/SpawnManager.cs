using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject [] foodPrefabs;

    private float spawnLimitXLeft = -10;
    private float spawnLimitXRight = 250;
    private float spawnLimitZLeft = -10;
    private float spawnLimitZRight = 200;
    private float spawnPosY = 50;

    private float startDelay = 1.0f;
    private float spawnInterval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFood", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomFood ()
    {
        int foodIndex = Random.Range(0, foodPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, Random.Range(spawnLimitZLeft, spawnLimitZRight));
        

        Instantiate(foodPrefabs[foodIndex], spawnPos, foodPrefabs[foodIndex].transform.rotation);
    }
}
