using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCadenasCode : MonoBehaviour
{
	public bool isOpen = false;
	private Animator anim;
	
    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("HautCadenasD").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnMouseDown()
    {
		GameObject cube1 = GameObject.Find("CubeCouleur1");
		GameObject cube2 = GameObject.Find("CubeCouleur2");
		GameObject cube3 = GameObject.Find("CubeCouleur3");
		GameObject cube4 = GameObject.Find("CubeCouleur4");
		
		if(cube1.GetComponent<ShadeChange>().cubeColor == 1
			&& cube2.GetComponent<ShadeChange>().cubeColor == 3
			&& cube3.GetComponent<ShadeChange>().cubeColor == 3
			&& cube4.GetComponent<ShadeChange>().cubeColor == 2)
		{
			isOpen = true;
			//Play anim and hide objects
			anim.SetBool("Active", true);
			gameObject.GetComponent<Disparition>().hide = true;
			GameObject.Find("HautCadenasD").GetComponent<Disparition>().hide = true;
			GameObject.Find("Code1").GetComponent<Disparition>().hide = true;
			GameObject.Find("Code2").GetComponent<Disparition>().hide = true;
			GameObject.Find("Code3").GetComponent<Disparition>().hide = true;
			GameObject.Find("Code4").GetComponent<Disparition>().hide = true;
			Debug.Log("CADENAS CODE OUVERT");
		}
    }
}
