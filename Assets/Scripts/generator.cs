using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour {

	float timer = 1;
	public GameObject[] gm;

	void Start()
	{

	}

	void Update()
	{
		if(timer > 0)
		{
			timer -= Time.deltaTime;
		}
		else{
			int chance = Random.Range(0, 101);

			float pos_x = Random.Range(-4.0f, 4.0f);

			if(chance <= 20)
			{
				Instantiate(gm[1], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
			}
			else
			{
				Instantiate(gm[0], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
			}
			timer = 0.7f;
		}	
		
	}
}
