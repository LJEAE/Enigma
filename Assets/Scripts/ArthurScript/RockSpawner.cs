using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    private GameObject spawnObject;
    public GameObject rockObject;
    private GameObject button;
    private PlacementIndicator placementIndicator;

    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
        button = GameObject.Find("FixBtn");

    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (placementIndicator.IsFixed == false)
            {
                InstantiateObject();
            }
        }
    }

    private void InstantiateObject()
    {
        Debug.Log("Objet > " + rockObject.name);
        if (spawnObject == null)
        {
            spawnObject = Instantiate(rockObject, placementIndicator.transform.position, placementIndicator.transform.rotation);

        }
        else
        {
            spawnObject.transform.position = placementIndicator.transform.position;
        }
    }
}
