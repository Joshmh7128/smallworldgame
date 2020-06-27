using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToList : MonoBehaviour
{
    enum whichTypes { pond, frog, preybird};
    [SerializeField] whichTypes ourType;

    // Start is called before the first frame update
    void Start()
    {
        switch ((int)ourType)
        {
            case 0:
                GameObject.Find("Main Camera").GetComponent<TargetManager>().ponds.Add(gameObject);
                break;

            case 1:
                GameObject.Find("Main Camera").GetComponent<TargetManager>().frogs.Add(gameObject);
                break;

            case 2:
                GameObject.Find("Main Camera").GetComponent<TargetManager>().preyBirds.Add(gameObject);
                break;
        }
    }
}
