using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCadenasKey : MonoBehaviour
{
	public bool isOpen = false;
	private Animator anim;
	
    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("HautCadenasG").GetComponent<Animator>();
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
					//Play anim and hide objects
					anim.SetBool("Active", true);
					gameObject.GetComponent<Disparition>().hide = true;
					GameObject.Find("HautCadenasG").GetComponent<Disparition>().hide = true;
					Debug.Log("CADENAS CLE OUVERT");
				}
			}
        }
    }
}
