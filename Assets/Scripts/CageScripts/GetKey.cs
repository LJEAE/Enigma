using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
	public bool getkey = false;
	private Animator anim;
	
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnMouseDown()
    {
		getkey = true;
		//Play anim and hide objects
		anim.SetBool("Active", true);
		gameObject.GetComponent<Disparition>().hide = true;
		GameObject.Find("Cube").GetComponent<Disparition>().hide = true;
		GameObject.Find("Cube (1)").GetComponent<Disparition>().hide = true;
		GameObject.Find("Cube (2)").GetComponent<Disparition>().hide = true;
		Debug.Log("CLE OBTENUE");
    }
}
