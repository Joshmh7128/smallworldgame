using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryAdditiveScript : MonoBehaviour
{
    // our animal choices
    public enum animalChoices { none, preyBird, predatorBird, butterflyAnimal, frogAnimal, deerAnimal, snakeAnimal, fishAnimal};
    // our animal choice
    public animalChoices animalChoice;
    // our animal spawn script
    public AnimalSpawnScript animalSpawnScript;
    // does rotate?
    [SerializeField] bool doesRotate;

    private void Start()
    {

        transform.Rotate(0.0f, Random.Range(0.0f, 360.0f), 0.0f);

        animalSpawnScript = GameObject.Find("AnimalSpawner").GetComponent<AnimalSpawnScript>();

        int i = (int)animalChoice;

        switch (i)
        {
            case 1:
                animalSpawnScript.preyBirdAttraction += 0.1f;
                break;

            case 2:
                animalSpawnScript.predatorBirdAttraction += 0.1f;
                break;

            case 3:
                animalSpawnScript.butterflyAttraction += 0.1f;
                break;

            case 4:
                animalSpawnScript.frogAttraction += 0.1f;
                break;

            case 5:
                animalSpawnScript.deerAttraction += 0.1f;
                break;

            case 6:
                animalSpawnScript.snakeAttraction += 0.1f;
                break;

            case 7:
                animalSpawnScript.fishAttraction += 0.1f;
                break;
        }
    }
}
