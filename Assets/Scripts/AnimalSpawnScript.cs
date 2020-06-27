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
    // 
    [SerializeField] GameObject preyBirdPrefab;

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
            AnimalCreation((int)preyBirdAttraction*10, preyBirdPrefab);
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
