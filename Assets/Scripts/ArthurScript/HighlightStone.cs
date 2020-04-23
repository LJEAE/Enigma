using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightStone : MonoBehaviour
{
	private bool highlight = false;
	public Material highlightMat;
	public Material defaultMat;
	public int number;
	
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
		Renderer rend = gameObject.GetComponent<Renderer>();
		GameObject sword = GameObject.Find("sword");
		
		if(highlight == false)
		{
			highlight = true;
			rend.material = highlightMat;
			sword.GetComponent<PullSword>().stackCode.Add(number);
		}
		else
		{
			highlight = false;
			rend.material = defaultMat;
			int index = 0;
			foreach( int stackNumber in sword.GetComponent<PullSword>().stackCode )
			{
				if(stackNumber == number)
				{
					index = sword.GetComponent<PullSword>().stackCode.IndexOf(stackNumber);
				}
			}
			sword.GetComponent<PullSword>().stackCode.RemoveAt(index);
		}
	}
	
}
