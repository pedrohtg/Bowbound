using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionTester : MonoBehaviour {

	public int r = 25;

	Vector3 move;
	GroundController gc;
	// Use this for initialization
	void Start () {
		gc = GameObject.FindObjectOfType<GroundController>();
	}

	// Update is called once per frame
	void Update () 
	{
		move = Vector3.zero;
		float spd = 1.0f;
		if(Input.GetKey(KeyCode.W))
		{
			move.y = spd * Time.deltaTime;
		}
		else if(Input.GetKey(KeyCode.S))
		{
			move.y = -spd * Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.D))
		{
			move.x = spd * Time.deltaTime;
		}
		else if(Input.GetKey(KeyCode.A))
		{
			move.x = -spd * Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.Space))
		{
			Vector2 p2;
			p2.x = transform.position.x;
			p2.y = transform.position.y;
			Debug.Log(p2);
			gc.DestroyGround(p2, r);
		}

		transform.position += move;
	}

}
