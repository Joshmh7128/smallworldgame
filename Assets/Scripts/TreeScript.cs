using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    private Transform spawn1;
    private Transform spawn2;
    private Transform spawn3;
    private Transform spawn4;
    private float spawnChance = 0.25f;
    public TargetManager tm;
    public GameObject fruitToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        GameObject spawned;
        tm = Camera.main.GetComponent<TargetManager>();
        spawn1 = this.transform.Find("FruitSpawn1");
        spawn2 = this.transform.Find("FruitSpawn2");
        spawn3 = this.transform.Find("FruitSpawn3");
        spawn4 = this.transform.Find("FruitSpawn4");
        float key = Random.Range(0f, 1f);
        if(key <= spawnChance)
        { 
            spawned = Instantiate(fruitToSpawn, spawn1);
            tm.fruits.Add(spawned);
        }
        key = Random.Range(0f, 1f);
        if (key <= spawnChance)
        {
            spawned = Instantiate(fruitToSpawn, spawn2);
            tm.fruits.Add(spawned);
        }
        key = Random.Range(0f, 1f);
        if (key <= spawnChance)
        {
            spawned = Instantiate(fruitToSpawn, spawn3);
            tm.fruits.Add(spawned);
        }
        key = Random.Range(0f, 1f);
        if (key <= spawnChance)
        {
            spawned = Instantiate(fruitToSpawn, spawn4);
            tm.fruits.Add(spawned);
        }

    }
}
