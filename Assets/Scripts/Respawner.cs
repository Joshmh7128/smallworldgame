using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    public float respawnTime = 10f;
    public int itemKey;
    public GameObject[] items;
    private TargetManager tm;

    private void Start()
    {
        tm = Camera.main.GetComponent<TargetManager>();
        StartCoroutine("StartRespawn");
    }

    IEnumerator StartRespawn()
    {
        yield return new WaitForSeconds(respawnTime);
        GameObject spawned = Instantiate(items[itemKey], this.gameObject.transform.position, Quaternion.identity);
        if(spawned.CompareTag("Fruit"))
        {
            tm.fruits.Add(spawned);
        }
        //Destroy(this.gameObject);
    }
}
