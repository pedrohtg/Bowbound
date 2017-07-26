using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prime31 {

public class MovementTester : MonoBehaviour {

	public float speed = 1.0f;
	private CharacterController2D charControl;

	Vector3 movement;
	// Use this for initialization
	void Start () {
		charControl = GetComponent<CharacterController2D>();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		movement = Vector3.zero;
		if(Input.GetKey(KeyCode.W)){
			movement.y += speed;
		}
		else if(Input.GetKey(KeyCode.S)){
			movement.y -= speed;
		}

		if(Input.GetKey(KeyCode.D)){
			movement.x += speed;
		}
		else if(Input.GetKey(KeyCode.A)){
			movement.x -= speed;
		}

		charControl.move(movement);
	}

}
}