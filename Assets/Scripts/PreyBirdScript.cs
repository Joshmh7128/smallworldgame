using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreyBirdScript : MonoBehaviour
{
    private MoveToTarget mt;

    private void Start()
    {
        mt = this.gameObject.GetComponent<MoveToTarget>();
        mt.targetType = MoveToTarget.targetChoice.fruit;
        mt.speed = 10;
    }

}
