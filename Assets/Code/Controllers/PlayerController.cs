using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	int OperationSystem;

	void Start () {
		OperationSystem = OS ();		
	}

	void Update () {
		if (GameController.Config_IsUsingJoystick()) {
			inputJoystick (OperationSystem);
		} else {
			inputKeyboard ();
		}
	}

	int OS() {
		if (Application.platform == RuntimePlatform.LinuxEditor || Application.platform == RuntimePlatform.LinuxPlayer) { 
			return 1; //Linux
		} else if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer) {
			return 2; //Windows
		} else if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer) {
			return 3; //MacOS
		}

		return 0;
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
		float X = Input.GetAxis ("Horizontal");
		float Y = Input.GetAxis ("Vertical");

		if (Mathf.Abs (X) >= Mathf.Abs (Y)) {

		} else {
		
		}

		switch (OS) {
		case 1: // LINUX
			if (Input.GetKey (KeyCode.Joystick1Button0)) {
				//A button;
			}
			if (Input.GetKey (KeyCode.Joystick1Button1)) {
				//B button;
			}
			if (Input.GetKey (KeyCode.Joystick1Button2)) {
				//X button;
			}
			if (Input.GetKey (KeyCode.Joystick1Button3)) {
				//Y button;
			}
			if (Input.GetKey (KeyCode.Joystick1Button4)) {
				//Left bumper
			}
			if (Input.GetKey (KeyCode.Joystick1Button5)) {
				//Right bumper
			}
			if (Input.GetKey (KeyCode.Joystick1Button6)) {
				//Back button
			}
			if (Input.GetKey (KeyCode.Joystick1Button7)) {
				//Start button
			}
			if (Input.GetKey (KeyCode.Joystick1Button8)) {}
			if (Input.GetKey (KeyCode.Joystick1Button9)) {
				//Left Stick Click
			}
			if (Input.GetKey (KeyCode.Joystick1Button10)) {
				//Right Stick Click
			}
			if (Input.GetKey (KeyCode.Joystick1Button11)) {
				//D-Pad Left
			} 
			if (Input.GetKey (KeyCode.Joystick1Button12)) {
				//D-Pad Right
			}
			if (Input.GetKey (KeyCode.Joystick1Button13)) {
				//D-Pad Up
			}
			if (Input.GetKey (KeyCode.Joystick1Button14)) {
				//D-Pad Down 
			}
			if (Input.GetKey (KeyCode.Joystick1Button15)) {}
			if (Input.GetKey (KeyCode.Joystick1Button16)) {}
			if (Input.GetKey (KeyCode.Joystick1Button17)) {}
			if (Input.GetKey (KeyCode.Joystick1Button18)) {}
			if (Input.GetKey (KeyCode.Joystick1Button19)) {}
		break;
		case 2: // WINDOWS
			if (Input.GetKey (KeyCode.Joystick1Button0)) {
				// A button
			}
			if (Input.GetKey (KeyCode.Joystick1Button1)) {
				// B button
			}
			if (Input.GetKey (KeyCode.Joystick1Button2)) {
				// X button
			}
			if (Input.GetKey (KeyCode.Joystick1Button3)) {
				// Y button
			}
			if (Input.GetKey (KeyCode.Joystick1Button4)) {
				// Left Bumper
			}
			if (Input.GetKey (KeyCode.Joystick1Button5)) {
				// Right Bumper
			}
			if (Input.GetKey (KeyCode.Joystick1Button6)) {
				// Back Bumper
			}
			if (Input.GetKey (KeyCode.Joystick1Button7)) {
				// Start button
			}
			if (Input.GetKey (KeyCode.Joystick1Button8)) {
				// Left Stick Click
			}
			if (Input.GetKey (KeyCode.Joystick1Button9)) {
				// Right Stick Click
			}
			if (Input.GetKey (KeyCode.Joystick1Button10)) {}
			if (Input.GetKey (KeyCode.Joystick1Button11)) {} 
			if (Input.GetKey (KeyCode.Joystick1Button12)) {}
			if (Input.GetKey (KeyCode.Joystick1Button13)) {}
			if (Input.GetKey (KeyCode.Joystick1Button14)) {}
			if (Input.GetKey (KeyCode.Joystick1Button15)) {}
			if (Input.GetKey (KeyCode.Joystick1Button16)) {}
			if (Input.GetKey (KeyCode.Joystick1Button17)) {}
			if (Input.GetKey (KeyCode.Joystick1Button18)) {}
			if (Input.GetKey (KeyCode.Joystick1Button19)) {}
			break;
		case 3: //OSX
			if (Input.GetKey (KeyCode.Joystick1Button0)) {}
			if (Input.GetKey (KeyCode.Joystick1Button1)) {}
			if (Input.GetKey (KeyCode.Joystick1Button2)) {}
			if (Input.GetKey (KeyCode.Joystick1Button3)) {}
			if (Input.GetKey (KeyCode.Joystick1Button4)) {}
			if (Input.GetKey (KeyCode.Joystick1Button5)) {
				// D-Pad Up
			}
			if (Input.GetKey (KeyCode.Joystick1Button6)) {
				// D-Pad Down
			}
			if (Input.GetKey (KeyCode.Joystick1Button7)) {
				// D-Pad Left
			}
			if (Input.GetKey (KeyCode.Joystick1Button8)) {
				// D-Pad Right
			}
			if (Input.GetKey (KeyCode.Joystick1Button9)) {
				// Start Button
			}
			if (Input.GetKey (KeyCode.Joystick1Button10)) {
				// Back Button
			}
			if (Input.GetKey (KeyCode.Joystick1Button11)) {
				// Left Stick Click
			} 
			if (Input.GetKey (KeyCode.Joystick1Button12)) {
				// Right Stick Click
			}
			if (Input.GetKey (KeyCode.Joystick1Button13)) {
				// Left Bumper
			}
			if (Input.GetKey (KeyCode.Joystick1Button14)) {
				// Right Bumper
			}
			if (Input.GetKey (KeyCode.Joystick1Button15)) {
				// Xbox Button
			}
			if (Input.GetKey (KeyCode.Joystick1Button16)) {
				// Button A
			}
			if (Input.GetKey (KeyCode.Joystick1Button17)) {
				// Button B
			}
			if (Input.GetKey (KeyCode.Joystick1Button18)) {
				// Button X
			}
			if (Input.GetKey (KeyCode.Joystick1Button19)) {
				// Button Y
			}
		break;
		}
	}
}