using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugclick : MonoBehaviour
{
	public string debug;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

	void OnMouseDown()
    {
		Debug.Log("CLICK" + debug);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
