using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public enum targetChoice { none, fruit, pond, preybird};
    public targetChoice targetType;
    public GameObject target;
    public float speed;
    private float hitDistance = 0.001f;
    private TargetManager tm;

    private void Start()
    {
        tm = Camera.main.GetComponent<TargetManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            Debug.DrawLine(transform.position, target.transform.position, Color.red);

            if (Vector3.Distance(transform.position, target.transform.position) > hitDistance)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);

                Vector3 targetDirection = target.transform.position - transform.position;

                Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, step * 2f, 0.0f);

                transform.rotation = Quaternion.LookRotation(newDirection);
            }  
            else
            {
                tm.fruits.Remove(target);
                if(target.CompareTag("Fruit"))
                {
                    GameObject resp = Instantiate(tm.respawner, target.transform.position, Quaternion.identity);
                    resp.GetComponent<Respawner>().itemKey = 0;
                }
                Destroy(target);
                gameObject.GetComponent<KillTime>().RemainingTime += 5; // add 5 seconds to the timer if you get to your targets
                //tm.RemoveNulls();
            }
        }
        else
        {
            int i = (int)targetType;
            switch(i)
            {
                case 1:
                    if (tm.fruits.Count > 0)
                    {
                        int targetPicker;
                        targetPicker = Random.Range(0, tm.fruits.Count);
                        target = tm.fruits[targetPicker];
                    }
                    break;

                case 2:
                    if (tm.ponds.Count > 0)
                    {
                        int targetPicker;
                        targetPicker = Random.Range(0, tm.ponds.Count);
                        target = tm.ponds[targetPicker];
                    }
                    break;

                case 3:
                    if (tm.preyBirds.Count > 0)
                    {
                        int targetPicker;
                        targetPicker = Random.Range(0, tm.preyBirds.Count);
                        target = tm.preyBirds[targetPicker];
                    }
                    break;
            }
        }
    }
}
