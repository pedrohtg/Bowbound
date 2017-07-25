using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	int OperationSystem;

	void Start () {
		OperationSystem = OS ();		
	}

	void Update () {
		inputJoystick (OperationSystem);
		inputKeyboard ();
	}

	int OS() {
		if (Application.platform == RuntimePlatform.LinuxEditor || Application.platform == RuntimePlatform.LinuxPlayer) { 
			return 1;
		} else if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer) {
			return 2;
		} else if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer) {
			return 3;
		}
	}



	void inputKeyboard() {
		bool UP, DOWN, LEFT, RIGHT;
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

		if (Input.GetKey (KeyCode.Alpha1)) {
		
		}

		if (Input.GetKey (KeyCode.Alpha2)) {
			
		}

		if (Input.GetKey (KeyCode.Alpha3)) {

		}

		if (Input.GetKey (KeyCode.Alpha4)) {

		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			
		}
	}

	void inputJoystick(int OS) {
		switch (OS) {
		case 1:
			float X, Y;

			X = Input.GetAxis ("Horizontal");
			Y = Input.GetAxis ("Vertical");

			if (Mathf.Abs (X) >= Mathf.Abs (Y)) {

			}

			if (Input.GetKey (KeyCode.Joystick1Button0)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button1)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button2)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button3)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button4)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button5)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button6)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button7)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button8)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button9)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button10)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button11)) {
			} 
			if (Input.GetKey (KeyCode.Joystick1Button12)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button13)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button14)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button15)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button16)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button17)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button18)) {
			}
			if (Input.GetKey (KeyCode.Joystick1Button19)) {
			}
			break;
		}
	}
}
