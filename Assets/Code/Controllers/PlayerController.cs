using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	void Start () {
		Debug.LogWarning ("Quero pegar blablaba");	

		inputJoystick ();
		inputKeyboard ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void inputKeyboard() {
		float UP, DOWN, LEFT, RIGHT;
		UP = Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.W);
		DOWN = Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.S);
		LEFT = Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.A);
		RIGHT = Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.D);

		if (UP || DOWN) {
			if (UP) {
				
			}	
			if (DOWN) {
				
			}
		} else if (LEFT || RIGHT) {
			if (LEFT) {
				
			}
			if (RIGHT) {
				
			}
		}
	}

	void inputJoystick() {
		if (Application.platform == RuntimePlatform.LinuxEditor || Application.platform == RuntimePlatform.LinuxPlayer) {
			Debug.LogWarning ("Estou no linux!");
		} else if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer) {
			Debug.LogWarning ("Estou no windows!");
		} else if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer) {
			Debug.LogWarning ("Estou no OSX!");
		}
	}
}
