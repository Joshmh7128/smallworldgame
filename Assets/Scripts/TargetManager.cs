using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public List<GameObject> fruits;

    public void RemoveNulls()
    {
        for (var i = fruits.Count - 1; i > - 1; i--)
        {
            if (fruits[i] == null)
                fruits.RemoveAt(i);
        }
    }
}
