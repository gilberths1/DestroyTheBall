using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] randomizerBola;

    public float minDelay = .1f;
    public float maxDelay = 1f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    IEnumerator SpawnFruits(){
        while(true)
        {
            float delay = Random.Range(minDelay, maxDelay); 
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            int n = Random.Range(0, 3);
            Instantiate(randomizerBola[n], spawnPoint.position, spawnPoint.rotation);
            
        }
    }
}
