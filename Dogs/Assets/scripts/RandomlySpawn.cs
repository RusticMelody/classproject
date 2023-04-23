using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlySpawn : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;

    public float spawnInterval = 1.0f; // interval between spawns
    public float spawnRadius = 5.0f; // radius of the spawn area

    private void Start()
    {
        // Start the spawning coroutine
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (true)
        {
            // Choose a random position within the spawn radius
            Vector3 spawnPos = transform.position + Random.insideUnitSphere * spawnRadius;

            // Choose a random game object to spawn
            GameObject prefabToSpawn = Random.Range(0, 2) == 0 ? object1 : object2;

            // Spawn the game object
            Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);

            // Wait for the specified interval before spawning the next object
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}