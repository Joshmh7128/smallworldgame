using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawnScript : MonoBehaviour
{
    // values of attraction per animal
    public float preyBirdAttraction;
    public float predatorBirdAttraction;
    public float preyAnimalAttraction;
    public float predatorAnimalAttraction;
    public float butterflyAttraction;
    public float frogAttraction;
    // 
    [SerializeField] GameObject preyBirdPrefab;
    [SerializeField] GameObject butterflyPrefab;
    [SerializeField] GameObject frogPrefab;

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
        yield return new WaitForSeconds(1f);

        spawnerPos = new Vector3(Random.Range(-60, 60), 0.5f, Random.Range(70, -70));

        if (butterflyAttraction >= 1)
        {
            AnimalCreation((int)butterflyAttraction, butterflyPrefab);
        }
        yield return new WaitForSeconds(1f);

        spawnerPos = new Vector3(Random.Range(-60, 60), 0.5f, Random.Range(70, -70));

        if (frogAttraction >= 1)
        {
            AnimalCreation((int)frogAttraction, frogPrefab);
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
