using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private float hitDistance = 0.001f;

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
                Debug.Log(gameObject.name + " reached target: " + target.name);
            }
        }
    }
}
