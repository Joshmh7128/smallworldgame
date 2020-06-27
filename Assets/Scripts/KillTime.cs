using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTime : MonoBehaviour
{
    public int RemainingTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DeathTime");
    }

    IEnumerator DeathTime()
    {
        RemainingTime -= 1;
        yield return new WaitForSeconds(1f);
        StartCoroutine("DeathTime");
    }

    private void FixedUpdate()
    {
        if (RemainingTime < 0 )
        {
            Destroy(gameObject);
        }
    }
}
