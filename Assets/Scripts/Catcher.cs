using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour {

	Transform tr;

	void Start()
	{
		tr = GetComponent<Transform>();
	}

	void FixedUpdate()
	{
		if(Input.GetKey("right") == true)
		{
			if(tr.position.x < 4f)tr.position += new Vector3(0.2f,0f,0f);
		}

		if(Input.GetKey("left") == true)
		{
			if(tr.position.x > -4f) tr.position += new Vector3(-0.2f, 0f, 0f);	
		}
	}
}
