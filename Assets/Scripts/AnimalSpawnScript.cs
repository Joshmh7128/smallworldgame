using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawnScript : MonoBehaviour
{
    // values of attraction per animal
    public float preyBirdAttraction;
    public float predatorBirdAttraction;
    public float butterflyAttraction;
    public float frogAttraction;
    public float fishAttraction;
    public float deerAttraction;
    public float snakeAttraction;
    // 
    [SerializeField] GameObject preyBirdPrefab;
    [SerializeField] GameObject predatorBirdPrefab;
    [SerializeField] GameObject butterflyPrefab;
    [SerializeField] GameObject frogPrefab;
    [SerializeField] GameObject fishPrefab;
    [SerializeField] GameObject deerPrefab;
    [SerializeField] GameObject snakePrefab;

    void Start()
    {
        StartCoroutine("AnimalSpawner");
    }

    IEnumerator AnimalSpawner()
    {
        // randomly move our spawner
        Vector3 spawnerPos;
        spawnerPos = new Vector3(Random.Range(-60, 60), 0.5f, Random.Range(70, -70));
        transform.position = spawnerPos;

        if (preyBirdAttraction >= 1)
        {
            AnimalCreation((int)preyBirdAttraction, preyBirdPrefab);
        }
       

        spawnerPos = new Vector3(Random.Range(-60, 60), 0.5f, Random.Range(70, -70));

        if (predatorBirdAttraction >= 1)
        {
            AnimalCreation((int)predatorBirdAttraction, predatorBirdPrefab);
        }
       

        spawnerPos = new Vector3(Random.Range(-60, 60), 0.5f, Random.Range(70, -70));

        if (butterflyAttraction >= 1)
        {
            AnimalCreation((int)butterflyAttraction, butterflyPrefab);
        }
       

        spawnerPos = new Vector3(Random.Range(-60, 60), 0.5f, Random.Range(70, -70));

        if (frogAttraction >= 1)
        {
            AnimalCreation((int)frogAttraction, frogPrefab);
        }
       

        spawnerPos = new Vector3(Random.Range(-60, 60), 0.5f, Random.Range(70, -70));

        if (fishAttraction >= 1)
        {
            AnimalCreation((int)fishAttraction, fishPrefab);
        }
       

        spawnerPos = new Vector3(Random.Range(-60, 60), 0.5f, Random.Range(70, -70));

        if (deerAttraction >= 1)
        {
            AnimalCreation((int)deerAttraction, deerPrefab);
        }
       

        spawnerPos = new Vector3(Random.Range(-60, 60), 0.5f, Random.Range(70, -70));

        if (snakeAttraction >= 1)
        {
            AnimalCreation((int)snakeAttraction, snakePrefab);
        }

        yield return new WaitForSeconds(1f);



        StartCoroutine("AnimalSpawner");
    }

    private void AnimalCreation(int times, GameObject animalPrefab)
    {
        while (times > 0)
        {
            GameObject animal = Instantiate(animalPrefab, this.gameObject.transform);
            animal.transform.parent = null;
            times -= 1;
        }
    }

    
}
