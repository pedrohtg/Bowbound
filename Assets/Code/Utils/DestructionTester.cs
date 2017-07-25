using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionTester : MonoBehaviour {

	GroundController gc;
	// Use this for initialization
	void Start () {
		gc=GameObject.FindObjectOfType<GroundController> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButton(0))
		{
			Vector3 pos=Input.mousePosition;
			Debug.Log("cliquei");
			gc.DestroyGround(new Vector2(pos.x,pos.y),5);
		}
	}
}
