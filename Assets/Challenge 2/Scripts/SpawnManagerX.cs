using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float currentTime;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
    }

    private void FixedUpdate()
    {
        // Only spawn a new ball after the spawn interval
        if (Time.fixedTime > (currentTime + spawnInterval))
        {
            SpawnRandomBall();
        }
    }


    // Spawn random ball at random x position at top of play area
    public void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random spawn interval between 3 and 5 inclusive
        spawnInterval = Random.Range(3.0f, 5.0f);

        // Update currentTime variable to keep track
        currentTime = Time.fixedTime;

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}
