using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullSword : MonoBehaviour
{
	public List<int> stackCode = new List<int>();
	private string code = "11241328";
	public bool getkey = false;
	private Animator anim;
	
    // Start is called before the first frame update
    void Start()
    {
		anim = gameObject.GetComponent<Animator>();
		GameObject.Find("LightEffect").GetComponent<ParticleSystem>().Pause();
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
			//Play anim and effect
			anim.SetBool("Active", true);
			GameObject.Find("LightEffect").GetComponent<ParticleSystem>().Play();
			Debug.Log("EPEE RETIREE");
		}
	}
}
