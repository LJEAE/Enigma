using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCadenasKey : MonoBehaviour
{
	public bool isOpen = false;
	
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
			if(go.GetComponent<GetKey>() != null){
				if(go.GetComponent<GetKey>().getkey == true){
					isOpen = true;
					//TODO play anim
					gameObject.SetActive(false);
					Debug.Log("CADENAS CLE OUVERT");
				}
			}
        }
    }
}
