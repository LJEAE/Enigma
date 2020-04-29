using UnityEngine;

public class FixCage : MonoBehaviour
{
    private PlacementIndicator placementIndicator;
    private GameObject cageObject;
    private GameObject btn;
    private Pose finalCagePose;


    public void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
        finalCagePose = FindObjectOfType<CageSpawner>().FinalCagePos;

        cageObject = GameObject.Find("toit");
        btn = GameObject.Find("FixerBtn");
    }

    public void FixeCagePosition()
    {
        Debug.Log("Cage fixé");
        placementIndicator.IsFixed = true;
        btn.SetActive(false);
    }

    void Update()
    {
        if(placementIndicator.IsFixed)
            cageObject.transform.SetPositionAndRotation(finalCagePose.position, finalCagePose.rotation);
    }
}
