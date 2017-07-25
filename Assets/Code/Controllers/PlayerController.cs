using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.LogWarning ("Quero pegar blablaba");	

		if (IsUnix ()) {
			Debug.LogWarning ("Estou em um sistema Unix");	
		} else {
			Debug.LogWarning ("Estou em um sistema Windows");
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static bool IsUnix()	{
		var platform = (int)System.Environment.OSVersion.Platform;
		return (platform == 4) || (platform == 6) || (platform == 128);
	}
}
