using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfig : MonoBehaviour 
{
	public static bool useJoystick	= true;
	public static int turnPreparationTime 		= 5;
	public static int maxTurnPreparationTime 	= 10;
	public static int turnTime 		= 30;
	public static int maxTurnTime 	= 60;

	public static int[] selectedClasses = new int[7];
	public static int characterAmount;


	public static void ResetGame()
	{
		for (int i = 0; i < 7; i++) 
		{
			selectedClasses [i] = 10;
		}
		characterAmount = 0;
	}
}
