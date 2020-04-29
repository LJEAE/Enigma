using UnityEngine;

public class FixRockObject : MonoBehaviour
{
    private PlacementIndicator placementIndicator;
    private GameObject cageObject;
    private GameObject btn;
    private Pose finalRockPose;
    
    public void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
        finalRockPose = FindObjectOfType<RockSpawner>().FinalRockPose;

        cageObject = GameObject.Find("toit");
        btn = GameObject.Find("FixBtn");
    }

    public void FixeRockPose()
    {
        Debug.Log("Pose fixé");
        placementIndicator.IsFixed = true;
        btn.SetActive(false);
    }

    void Update()
    {
        if (placementIndicator.IsFixed)
            cageObject.transform.SetPositionAndRotation(finalRockPose.position, finalRockPose.rotation);
    }
}
