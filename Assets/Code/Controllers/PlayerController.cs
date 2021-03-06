﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public bool inputActive = true;
	int OperationSystem;

	void Start () {
		OperationSystem = OS ();
	}

	void Update () {
		if (inputActive) 
		{
			if (GameConfig.useJoystick) 
			{
				inputJoystick (OperationSystem);
			}
			else
			{
				inputKeyboard ();
			}
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
		LEFT = Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A);
		RIGHT = Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKey (KeyCode.D);

		if (UP || DOWN) {
			if (UP) {
				GameController.ActiveHero().ChangeAngle(true);
			}
			if (DOWN) {
				GameController.ActiveHero().ChangeAngle(false);
			}
		} else if (LEFT || RIGHT) {
			if (LEFT) {
				GameController.ActiveHero().Walk(true);
			}
			if (RIGHT) {
				GameController.ActiveHero().Walk(false);
			}
		}

		if (Input.GetKey (KeyCode.Alpha1)) {
			GameController.ActiveHero().ChangeSkill(1);
		}
		if (Input.GetKey (KeyCode.Alpha2)) {
			GameController.ActiveHero().ChangeSkill(2);
		}

		if (Input.GetKey (KeyCode.Alpha3)) {
			GameController.ActiveHero().ChangeSkill(3);
		}

		if (Input.GetKey (KeyCode.Alpha4)) {
			GameController.ActiveHero().ChangeSkill(4);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			GameController.ActiveHero().ChangeLaunchForce ();
		}

		if (Input.GetKeyUp (KeyCode.Space)){
			GameController.ActiveHero().Attack();
		}
	}

	void inputJoystick(int OS) {
		float X = Input.GetAxis ("Horizontal");
		float Y = Input.GetAxis ("Vertical");

		if (Mathf.Abs (X) >= 0.25F || Mathf.Abs (Y) >= 0.25F) {
			if (Mathf.Abs(X) >= Mathf.Abs(Y)) {
				bool a;
				a = (X > 0) ? false : true;
				GameController.ActiveHero().Walk(a);
			} else {
				bool a;
				a = (Y > 0) ? true : false;
				GameController.ActiveHero().ChangeAngle(a);
			}
		}

		switch (OS) {
		case 1: // LINUX
			if (Input.GetKey (KeyCode.Joystick1Button0)) {
				//A button;
				GameController.ActiveHero().ChangeSkill(1);
			}
			if (Input.GetKey (KeyCode.Joystick1Button1)) {
				//B button;
				GameController.ActiveHero().ChangeSkill(2);
			}
			if (Input.GetKey (KeyCode.Joystick1Button2)) {
				//X button;
				GameController.ActiveHero().ChangeSkill(3);
			}
			if (Input.GetKey (KeyCode.Joystick1Button3)) {
				//Y button;
				GameController.ActiveHero().ChangeSkill(4);
			}

			/* Botões abaixados */
			if (Input.GetKeyDown(KeyCode.Joystick1Button4)) {
				//Left bumper
				GameController.ActiveHero().ChangeLaunchForce();
			}
			if (Input.GetKeyDown(KeyCode.Joystick1Button5)) {
				//Right bumper
				GameController.ActiveHero().ChangeLaunchForce();
			}

			/* Botões em pé */
			if (Input.GetKeyUp(KeyCode.Joystick1Button4)) {
				//Left bumper
				GameController.ActiveHero().Attack();
			}
			if (Input.GetKeyUp(KeyCode.Joystick1Button5)) {
				//Right bumper
				GameController.ActiveHero().Attack();
			}


			// if (Input.GetKey (KeyCode.Joystick1Button6)) {
			// 	//Back button
			// }
			// if (Input.GetKey (KeyCode.Joystick1Button7)) {
			// 	//Start button
			// }
			// if (Input.GetKey (KeyCode.Joystick1Button8)) {}
			// if (Input.GetKey (KeyCode.Joystick1Button9)) {
			// 	//Left Stick Click
			// }
			// if (Input.GetKey (KeyCode.Joystick1Button10)) {
			// 	//Right Stick Click
			// }
			if (Input.GetKey (KeyCode.Joystick1Button11)) {
				//D-Pad Left
				GameController.ActiveHero().Walk(true);
			}
			if (Input.GetKey (KeyCode.Joystick1Button12)) {
				//D-Pad Right
				GameController.ActiveHero().Walk(false);
			}
			if (Input.GetKey (KeyCode.Joystick1Button13)) {
				//D-Pad Up
				GameController.ActiveHero().ChangeAngle(true);
			}
			if (Input.GetKey (KeyCode.Joystick1Button14)) {
				//D-Pad Down
				GameController.ActiveHero().ChangeAngle(false);
			}
			// if (Input.GetKey (KeyCode.Joystick1Button15)) {}
			// if (Input.GetKey (KeyCode.Joystick1Button16)) {}
			// if (Input.GetKey (KeyCode.Joystick1Button17)) {}
			// if (Input.GetKey (KeyCode.Joystick1Button18)) {}
			// if (Input.GetKey (KeyCode.Joystick1Button19)) {}
		break;
		case 2: // WINDOWS
			if (Input.GetKey (KeyCode.Joystick1Button0)) { // A button
				GameController.ActiveHero().ChangeSkill(1);
			}
			if (Input.GetKey (KeyCode.Joystick1Button1)) { // B button
				GameController.ActiveHero().ChangeSkill(2);
			}
			if (Input.GetKey (KeyCode.Joystick1Button2)) { // X button
				GameController.ActiveHero().ChangeSkill(3);
			}
			if (Input.GetKey (KeyCode.Joystick1Button3)) { // Y button
				GameController.ActiveHero().ChangeSkill(4);
			}

            /* Botões pressionados */
			if (Input.GetKeyDown (KeyCode.Joystick1Button4)) {
                // Left Bumper
                GameController.ActiveHero().ChangeLaunchForce();
			}

			if (Input.GetKeyDown (KeyCode.Joystick1Button5)) {
				// Right Bumper
                GameController.ActiveHero().ChangeLaunchForce();
			}

			/* Botões soltos */
            if (Input.GetKeyDown (KeyCode.Joystick1Button4)) {
                // Left Bumper
                GameController.ActiveHero().Attack();
			}

			if (Input.GetKeyUp (KeyCode.Joystick1Button5)) {
				// Right Bumper
				GameController.ActiveHero().Attack();
			}

            // if (Input.GetKey (KeyCode.Joystick1Button6)) {
			// 	// Back Bumper
			// }
            //
			// if (Input.GetKey (KeyCode.Joystick1Button7)) {
			// 	// Start button
			// }
			// if (Input.GetKey (KeyCode.Joystick1Button8)) {
			// 	// Left Stick Click
			// }
			// if (Input.GetKey (KeyCode.Joystick1Button9)) {
			// 	// Right Stick Click
			// }

			//if (Input.GetKey (KeyCode.Joystick1Button10)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button11)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button12)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button13)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button14)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button15)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button16)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button17)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button18)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button19)) {}
			break;
		case 3: //OSX
			//if (Input.GetKey (KeyCode.Joystick1Button0)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button1)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button2)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button3)) {}
			//if (Input.GetKey (KeyCode.Joystick1Button4)) {}
			if (Input.GetKey (KeyCode.Joystick1Button5)) {
				// D-Pad Up
				GameController.ActiveHero().ChangeAngle(true);
			}
			if (Input.GetKey (KeyCode.Joystick1Button6)) {
				// D-Pad Down
				GameController.ActiveHero().ChangeAngle(false);
			}
			if (Input.GetKey (KeyCode.Joystick1Button7)) {
				// D-Pad Left
				GameController.ActiveHero().Walk(false);
			}
			if (Input.GetKey (KeyCode.Joystick1Button8)) {
				// D-Pad Right
				GameController.ActiveHero().Walk(true);
			}
			// if (Input.GetKey (KeyCode.Joystick1Button9)) {
			// 	// Start Button
			// }
			// if (Input.GetKey (KeyCode.Joystick1Button10)) {
			// 	// Back Button
			// }
			// if (Input.GetKey (KeyCode.Joystick1Button11)) {
			// 	// Left Stick Click
			// }
			// if (Input.GetKey (KeyCode.Joystick1Button12)) {
			// 	// Right Stick Click
			// }

			/* Botões apertados */
			if (Input.GetKeyDown (KeyCode.Joystick1Button13)) {
				// Left Bumper
				GameController.ActiveHero().ChangeLaunchForce();
			}
			if (Input.GetKeyDown (KeyCode.Joystick1Button14)) {
				// Right Bumper
				GameController.ActiveHero().ChangeLaunchForce();
			}

			/* Botões soltos */
			if (Input.GetKeyUp (KeyCode.Joystick1Button13)) {
				// Left Bumper
				GameController.ActiveHero().Attack();
			}
			if (Input.GetKeyUp (KeyCode.Joystick1Button14)) {
				// Right Bumper
				GameController.ActiveHero().Attack();
			}


			// if (Input.GetKey (KeyCode.Joystick1Button15)) {
			// 	// Xbox Button
			// }
			if (Input.GetKey (KeyCode.Joystick1Button16)) {
				// Button A
				GameController.ActiveHero().ChangeSkill(1);
			}
			if (Input.GetKey (KeyCode.Joystick1Button17)) {
				// Button B
				GameController.ActiveHero().ChangeSkill(2);
			}
			if (Input.GetKey (KeyCode.Joystick1Button18)) {
				// Button X
				GameController.ActiveHero().ChangeSkill(3);
			}
			if (Input.GetKey (KeyCode.Joystick1Button19)) {
				// Button Y
				GameController.ActiveHero().ChangeSkill(4);
			}
		break;
		}
	}
}
