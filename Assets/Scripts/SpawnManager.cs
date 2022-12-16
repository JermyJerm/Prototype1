using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Car;
    private Vector3 spawnPos = new Vector3(8, 16, 200);
    private Vector3 spawnPos2 = new Vector3(-8, 1, 200);
    private float startDelay = 2;
    private float repeatRate = 1;
    private PlayerController playerControllerScript;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        Instantiate(Car, spawnPos, Car.transform.rotation);
        Instantiate(Car, spawnPos2, Car.transform.rotation);
    }
}
