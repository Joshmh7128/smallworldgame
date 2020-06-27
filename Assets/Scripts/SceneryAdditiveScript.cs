using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryAdditiveScript : MonoBehaviour
{
    // our animal choices
    public enum animalChoices { none, preyBird, predatorBird, preyAnimal, predatorAnimal, butterflyAnimal, frogAnimal};
    // our animal choice
    public animalChoices animalChoice;
    // our animal spawn script
    public AnimalSpawnScript animalSpawnScript;
    // does rotate?
    [SerializeField] bool doesRotate;

    private void Start()
    {
        if (doesRotate == true)
        {
            transform.Rotate(0.0f, Random.Range(0.0f, 360.0f), 0.0f);
        }

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

            case 5:
                animalSpawnScript.butterflyAttraction += 0.1f;
                break;

            case 6:
                animalSpawnScript.butterflyAttraction += 0.1f;
                break;
        }
    }
}
