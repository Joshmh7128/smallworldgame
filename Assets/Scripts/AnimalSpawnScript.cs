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
        if (preyBirdAttraction >= 1)
        {
            AnimalCreation((int)preyBirdAttraction*10, preyBirdPrefab);
        }
        yield return new WaitForSeconds(5f);
        StartCoroutine("AnimalSpawner");
    }

    private void AnimalCreation(int times, GameObject animalPrefab)
    {
        while (times > 0)
        {
            Instantiate(animalPrefab);
            times -= 1;
        }
    }
}
