using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objects;

    float minY = -12f;
    float maxY = 18f;

    float xPos = -8f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1.7f, 1.7f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnObjects()
    {

        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(xPos, randomY, 0);
        int randomIndex = Random.Range(0, objects.Length);
        Instantiate(objects[randomIndex], spawnPosition, Quaternion.identity);


    }
}
