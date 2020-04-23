using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadeChange : MonoBehaviour
{
    public Material  texture;
	public Material  texture2;
	public Material  texture3;
	public Material  texture4;
	public Material  texture5;
	private int index = -1;
	private Material  selectTexture;
	public int cubeColor = 0;
	
	
    // Use this for initialization
    void Start () 
	{
        
    }
	
	void OnMouseDown()
    {
		Renderer rend = gameObject.GetComponent<Renderer>();
		
		index++;
		
		if(index == 0)
		{
			selectTexture = texture;
			cubeColor = 1;
		}
		if(index == 1)
		{ 
			selectTexture = texture2; 
			cubeColor = 2;
		}
		if(index == 2)
		{ 
			selectTexture = texture3; 
			cubeColor = 3;
		}
		if(index == 3)
		{ 
			selectTexture = texture5; 
			cubeColor = 4;
		}
		if(index == 4)
		{
			selectTexture = texture4; 
			cubeColor = 5;
			index = -1;
		}
		rend.material = selectTexture; 
		
    }
	
	void Update()
    {
        
    }
}
