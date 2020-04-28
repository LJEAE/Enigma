using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparition : MonoBehaviour
{
	public bool hide = false;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hide == true)
		{
			Color color = gameObject.GetComponent<MeshRenderer>().material.color ;
			color.a -= Time.deltaTime * 0.3f;
			gameObject.GetComponent<MeshRenderer>().material.color = color ;
		}
    }
}
