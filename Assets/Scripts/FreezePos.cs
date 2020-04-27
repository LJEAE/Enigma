using UnityEngine;

public class FreezePos : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    bool isLock;
    
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        isLock = GetComponent<PlacementIndicator>().IsFixed;
    }
    void Update()
    {
        if(isLock)
        {
            m_Rigidbody.constraints = 
                RigidbodyConstraints.FreezeRotationX | 
                RigidbodyConstraints.FreezeRotationZ | 
                RigidbodyConstraints.FreezePositionY | 
                RigidbodyConstraints.FreezePositionZ;
        }
        

    }
}
