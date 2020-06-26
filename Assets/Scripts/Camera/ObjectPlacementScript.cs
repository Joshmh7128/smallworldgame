using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPlacementScript : MonoBehaviour
{
    // basic object stuff
    public GameObject placeableGrassObjectPrefab; // the object we are placing
    public GameObject placeableTreeObjectPrefab; // the object we are placing
    public GameObject placeableObjectPrefab = null;
    private GameObject currentPlaceableObject; // the object we placed last

    // UI and world stuff
    public bool buildMode = false; // are we in build mode?
    public Vector3 mouseWorldPos; // what is our mouses world position?
    public Button GrassButton;
    public Button TreeButton;

    // start runs at the start of the object
    public void Start()
    {
        GrassButton.onClick.AddListener(delegate { SelectObject(placeableGrassObjectPrefab); });
        TreeButton.onClick.AddListener(delegate { SelectObject(placeableTreeObjectPrefab); });
    }

    // update runs every tick
    private void Update()
    {
        HandleNewObjectHotkey();

        if (currentPlaceableObject != null)
        {
            MoveCurrentObjectToMouse(); // moves the placement to mouse
            ReleaseIfClicked(); // releases the object we're placing
        }

        // toggle build mode
        if (Input.GetKeyDown("f"))
        {
            // toggle build mode
            buildMode = !buildMode;
        }

        // get our mouses world position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            //currentPlaceableObject.transform.position = hitInfo.point;
           // currentPlaceableObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }

    }

    // handle a new object
    private void HandleNewObjectHotkey()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (buildMode == true)
            if (currentPlaceableObject != null)
            {
                Destroy(currentPlaceableObject);
            }
            else
            {
                currentPlaceableObject = Instantiate(placeableObjectPrefab);
            }
        }
    }

    // places the object at the mouse
    private void MoveCurrentObjectToMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            currentPlaceableObject.transform.position = hitInfo.point;
            currentPlaceableObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
    }

    // release it if clicked
    private void ReleaseIfClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentPlaceableObject = null;
        }
    }

    // set our object we want to place
    private void SelectObject(GameObject gameObject)
    {
        placeableObjectPrefab = gameObject;
    }

}
