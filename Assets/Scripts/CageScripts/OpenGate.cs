using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
	public bool isOpen = false;
	private Animator anim;
	
    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("Porte").GetComponent<Animator>();
    }
	
    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnMouseDown()
    {
		
		if(GameObject.Find("CadenasG").GetComponent<OpenCadenasKey>().isOpen == true 
			&& GameObject.Find("CadenasD").GetComponent<OpenCadenasCode>().isOpen == true)
		{
			GameObject.Find("Porte").GetComponent<OpenGate>().isOpen = true;
			//Play anim
			anim.SetBool("Active", true);
			Debug.Log("PORTE OUVERTE");
		}
    }
}
