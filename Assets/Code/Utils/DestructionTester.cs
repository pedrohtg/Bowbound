using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionTester : MonoBehaviour {

	public int r = 25;
	public GameObject bullet;

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
			gc.DestroyGround(p2, r);
			//gc.DestroyArc(p2,p2,p2);
		}

		if(Input.GetKeyDown(KeyCode.T))
		{
			GameObject go = GameObject.Instantiate(bullet);
			go.GetComponent<BulletController>().Initialize( (new Vector2(1,2)).normalized, 0.15f);
		}

		transform.position += move;
	}

}
