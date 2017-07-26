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
				_myInstance = go.AddComponent<GameController> ();
			}
			else 
			{
				_myInstance = go.GetComponent<GameController> ();
				if (_myInstance == null) 
				{
					_myInstance = go.AddComponent<GameController> ();
				}
			}
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

	public static void 				Kill(HeroController hero)
	{
	}

	#region TURN MANAGEMENT

	public static void BeginTurn()
	{
		Instance ()._myText_TurnPrepTime.gameObject.SetActive (true);

		Instance()._myText_TurnTime.text 	= "" + Instance()._myTurnTime;
		Instance()._myText_TurnPrepTime.text= "" + Instance()._myTurnPrepTime;

		if (Instance ()._myActiveHero != null)
			Instance ()._myText_PlayerName.text	= "" + Instance ()._myActiveHero.GetName ();
		else
			Instance ()._myText_PlayerName.text	= "CADE HEROI?";

		Instance ()._myCurrTurnPrepTime = Instance ()._myTurnPrepTime;
		Instance ()._myCurrTurnTime 	= Instance ()._myTurnTime;

		if (!Instance ().IsInvoking ("TurnStartCountDown")) 
		{
			Instance ().Invoke ("TurnStartCountDown", 1.0f);
		}
	}

	private void TurnStartCountDown()
	{
		if (Instance ()._myCurrTurnPrepTime == 0) 
		{
			Invoke ("TurnCountDown", 1.0f);
			Instance ()._myText_TurnPrepTime.gameObject.SetActive (false);
		} 
		else 
		{
			Instance ()._myCurrTurnPrepTime--;
			Instance ()._myText_TurnPrepTime.text = "" + Instance ()._myCurrTurnPrepTime;

			if (!Instance ().IsInvoking ("TurnStartCountDown")) 
			{
				Instance ().Invoke ("TurnStartCountDown", 1.0f);
			}
		}
	}

	private void TurnCountDown()
	{
		int t = Instance ()._myCurrTurnTime;
		if (t == 0) 
		{
			Debug.Log ("END TURN!!!");
		} 
		else 
		{
			t--;
			Instance ()._myText_TurnTime.text = "" + t;
			Instance ().Invoke ("TurnCountDown", 1.0f);
			Instance ()._myCurrTurnTime = t;
		}
	}

	#endregion

	#region GAME CONFIGURATIONS
	private int				_myTurnPrepTime		= 5;
	private int				_myCurrTurnPrepTime	= 5;
	private int				_myTurnTime			= 30;
	private int				_myCurrTurnTime		= 30;
	private bool			_myIsUsingJoystick	= true;

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

	UnityEngine.UI.Text _myText_TurnTime;
	UnityEngine.UI.Text _myText_TurnPrepTime;
	UnityEngine.UI.Text _myText_PlayerName;

	void Start()
	{
		Instance()._myText_TurnTime		= GameObject.Find ("<TurnTime>").GetComponent<UnityEngine.UI.Text>();
		Instance()._myText_TurnPrepTime	= GameObject.Find ("<TurnBegins>").GetComponent<UnityEngine.UI.Text>();
		Instance()._myText_PlayerName	= GameObject.Find ("<PlayerName>").GetComponent<UnityEngine.UI.Text>();

		BeginTurn ();
	}
}
