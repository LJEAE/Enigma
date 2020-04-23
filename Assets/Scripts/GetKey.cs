using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
	public bool getkey = false;
	
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
		getkey = true;
		//TODO play anim
		gameObject.SetActive(false);
		Debug.Log("CLE OBTENUE");
    }
}
