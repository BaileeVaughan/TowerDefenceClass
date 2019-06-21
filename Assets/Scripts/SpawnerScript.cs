using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float spawnRadius = 5f;
    public float spawnRate = 1f;
    public float spawnFactor = 0f;
    public GameObject[] prefabs;

    void Update()
    {
        HandleSpawn();
    }

    void HandleSpawn()
    {
        spawnFactor += Time.deltaTime;
        if (spawnFactor > spawnRate)
        {
            int randomIndex = Random.Range(0, prefabs.Length);
            Spawn(prefabs[randomIndex]);
            spawnFactor = 0;
        }
    }

    void Spawn(GameObject gObject)
    {
        GameObject newObject = Instantiate(gObject);
        Vector3 randomPoint = Random.insideUnitCircle * spawnRadius;
        newObject.transform.position = transform.position + randomPoint;
    }
}
