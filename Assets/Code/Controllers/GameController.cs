using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{
	private static GameController _myInstance;

	private static GameController Instance()
	{
		if (_myInstance == null) 
		{
			GameObject go = GameObject.Find ("<GameController>");
			if (go == null) 
			{
				go = new GameObject ("<GameController>");
			}
			_myInstance = go.AddComponent<GameController> ();
		}

		return _myInstance;
	}
		
	private Vector2 		_myWind;
	private HeroController	_myActiveHero;

	public static Vector2			Wind()
	{
		return Instance ()._myWind;
	}

	public static HeroController 	ActiveHero()
	{
		return Instance ()._myActiveHero;
	}

	public static void 	Kill(HeroController hero)
	{
	}

	#region GAME CONFIGURATIONS
	private int				_myTurnPrepTime;
	private int				_myTurnTime;
	private bool			_myIsUsingJoystick;

	public static int	Config_TurnPrepTime()
	{
		return Instance()._myTurnPrepTime;
	}

	public static int	Config_TurnTime()
	{
		return Instance()._myTurnTime;
	}

	public static bool 	Config_IsUsingJoystick()
	{
		return Instance()._myIsUsingJoystick;
	}
	#endregion

}
