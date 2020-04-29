using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    private GameObject spawnObject;
    public GameObject rockObject;
    private GameObject button;
    private PlacementIndicator placementIndicator;
    Pose finalRockPose;

    public Pose FinalRockPose { get => finalRockPose; set => finalRockPose = value; }

    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
        button = GameObject.Find("FixerBtn");
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (placementIndicator.IsFixed == false)
            {
                InstantiateObject();
            }
            else
            {
                finalRockPose.position = spawnObject.transform.position;
                finalRockPose.rotation = spawnObject.transform.rotation;
            }
        }
    }

    private void InstantiateObject()
    {
        Debug.Log("Objet > " + rockObject.name);
        if (spawnObject == null)
        {
            spawnObject = Instantiate(rockObject, placementIndicator.transform.position, Quaternion.identity);
        }
        else
        {
            spawnObject.transform.position = placementIndicator.transform.position;
        }
    }
}
