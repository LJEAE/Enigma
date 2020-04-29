using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixObjects : MonoBehaviour
{
    private PlacementIndicator placementIndicator;
    private GameObject game;
    private GameObject btn;
    public string objName;
    public string btnName;

    public void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();

        game = GameObject.Find(objName);
        btn = GameObject.Find(btnName);
    }

    public void FixePosition()
    {
        Debug.Log("Pose fixé");
        placementIndicator.IsFixed = true;
        btn.SetActive(false);
    }
}
