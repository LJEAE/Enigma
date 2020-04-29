using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementIndicator : MonoBehaviour
{
    private ARRaycastManager raycastManager;
    private GameObject visual;
    private GameObject button;
    private GameObject headPanel;
    public string panelName;
    public string btnName;

    public bool IsFixed { get; set; } = false;

    void Start()
    {
        // Get the component
        raycastManager = FindObjectOfType<ARRaycastManager>();
        visual = transform.GetChild(0).gameObject;
        button = GameObject.Find(btnName);
        headPanel = GameObject.Find(panelName);

        // Hide the placement visual + button
        visual.SetActive(false);
        button.SetActive(false);

    }

    void Update()
    {
        if (IsFixed == false)
        {
            UpdatePlacementIndicationPosition();
        }
        else
        {

            if (visual.activeInHierarchy)
            {
                visual.SetActive(false);
            }
        }
    }

    private void UpdatePlacementIndicationPosition()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        raycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.PlaneWithinPolygon);

        if (hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;

            if (!visual.activeInHierarchy)
                visual.SetActive(true);

            if (!button.activeInHierarchy)
                button.SetActive(true);

            if (headPanel.activeInHierarchy)
                headPanel.SetActive(false);

        }
    }
}
