using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpotlightFollowingCamera : MonoBehaviour
{
    public string objectName;

    void Update()
    {
        if(GameObject.Find(objectName))
        {
            GameObject gameObject = GameObject.Find(objectName);
            transform.LookAt(gameObject.transform.position);
        }
    }
}
