using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnMouseDown()
    {
		foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
        {
			if(go.GetComponent<OpenCadenasKey>() != null){
				if(go.GetComponent<OpenCadenasKey>().isOpen == true && go.GetComponent<OpenCadenasCode>().isOpen == true){
					//TODO play anim
					GameObject.Find("Porte").SetActive(false);
					Debug.Log("PORTE OUVERTE");
				}
			}
        }
    }
}
