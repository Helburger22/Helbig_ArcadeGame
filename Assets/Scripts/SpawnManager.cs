using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject powerupPrefab;
    public int powerupCount;
    private float xRange =15.0f;
    private float zRange = 9.0f;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        SpawnPowerup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition(){
        float spawnPosX = Random.Range(-xRange, xRange);
        float spawnPosZ = Random.Range(-zRange, zRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;

    }
    public void SpawnPowerup(){
        StartCoroutine(SpawnDelay());
    }
    IEnumerator SpawnDelay(){
         yield return new WaitForSeconds(delay);
         Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);

    }
}
