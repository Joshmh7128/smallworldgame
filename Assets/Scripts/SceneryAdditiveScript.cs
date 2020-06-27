using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryAdditiveScript : MonoBehaviour
{
    // our animal choices
    public enum animalChoices { none, preyBird, predatorBird, preyAnimal, predatorAnimal };
    // our animal choice
    public animalChoices animalChoice;
    // our animal spawn script
    public AnimalSpawnScript animalSpawnScript;

    private void Start()
    {
        
        animalSpawnScript = GameObject.Find("AnimalSpawner").GetComponent<AnimalSpawnScript>();

        int i = (int)animalChoice;

        switch (i)
        {
            case 1:
                Debug.Log("Tree Placed!");
                animalSpawnScript.preyBirdAttraction += 0.1f;
                break;

            case 2:
                animalSpawnScript.predatorBirdAttraction += 0.1f;
                break;

            case 3:
                animalSpawnScript.preyAnimalAttraction += 0.1f;
                break;

            case 4:
                animalSpawnScript.predatorAnimalAttraction += 0.1f;
                break;
        }
    }
}
