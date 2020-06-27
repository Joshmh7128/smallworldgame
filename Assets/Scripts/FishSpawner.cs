using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    [SerializeField] GameObject fishPrefab;
    [SerializeField] int respawnTime;

    private void Start()
    {
        StartCoroutine("SpawnFish");
    }

    IEnumerator SpawnFish()
    {
       Instantiate(fishPrefab, gameObject.transform);
       yield return new WaitForSeconds(respawnTime);
       StartCoroutine("SpawnFish");
    }

}
