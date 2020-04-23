using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullSword : MonoBehaviour
{
	public List<int> stackCode = new List<int>();
	private string code = "11241328";
	
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
		string foundCode = "";
		
        foreach( int number in stackCode )
        {
            foundCode = foundCode + number;
        }
		
		if(foundCode == code)
		{
			//TODO place animation here
			Debug.Log("EPEE RETIREE");
			gameObject.SetActive(false);
		}
	}
}
