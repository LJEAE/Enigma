using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	//adjust this to change speed
	public float speed = 5f;
	//adjust this to change how high it goes
	public float height = 0.3f;
	public float height2 = 1f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Porte").GetComponent<OpenGate>().isOpen == true)
        {
            transform.Rotate(
            0,
            1000 * Time.deltaTime,
            0
            );
			
			//get the objects current position and put it in a variable so we can access it later with less code
			Vector3 pos = transform.position;
			//calculate what the new Y position will be
			float newY = Mathf.Sin(Time.time * speed);
			//set the object's Y to the new calculated Y
			transform.position = new Vector3(pos.x, newY * height - height2, pos.z);
        }
    }
}
