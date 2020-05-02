using UnityEngine;

public class CageSpawner : MonoBehaviour
{
    private GameObject spawnObject;
    public GameObject cageObject;
    private GameObject button;
    private PlacementIndicator placementIndicator;
    Pose finalCagePos;

    public Pose FinalCagePos { get => finalCagePos; set => finalCagePos = value; }

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
            else
            {
                finalCagePos.position = spawnObject.transform.position;
                finalCagePos.rotation = spawnObject.transform.rotation;
            }
        }
    }

    private void InstantiateObject()
    {
        Debug.Log("Objet > " + cageObject.name);
        if (spawnObject == null)
        {
            Vector3 cagePosition = new Vector3(placementIndicator.transform.position.x, placementIndicator.transform.position.y + 2, placementIndicator.transform.position.z);
            spawnObject = Instantiate(cageObject, cagePosition, Quaternion.identity);
        }
        else
        {
            spawnObject.transform.position = placementIndicator.transform.position;
        }
    }
}
