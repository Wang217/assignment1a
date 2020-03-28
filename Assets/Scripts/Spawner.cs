using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    private Vector2 spawnValues;

    private float randY;
    
    public float spawnRate;
    public float nextSpawn;

    public GameObject newObject1, newObject2, newObject3, newObject4;

    void Update() {
        if(Time.time > nextSpawn) {

            GameObject useObject = RandomObjectGenerated();

            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(-2, -6);
            spawnValues = new Vector2(transform.position.x, randY);

            Instantiate(useObject, spawnValues, Quaternion.identity);
        }
    }

    private GameObject RandomObjectGenerated() {
        GameObject returnObject = newObject1;
        int number = Random.Range(1,5);

        if(number == 1) {
            returnObject = newObject1;
        } else if(number == 2) {
            returnObject = newObject2;
        } else if(number == 3) {
            returnObject = newObject3;
        } else if(number == 4) {
            returnObject = newObject4;
        }

        return returnObject;
    }
}
