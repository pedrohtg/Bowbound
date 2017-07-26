using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour 
{
	public GameObject[] HeroPrefabs;

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
	private ArrayList 		_myHeroActionOrder;

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
		Instance ()._myActiveHero = ((GameObject)(Instance ()._myHeroActionOrder [0])).GetComponent<HeroController> ();

		Instance ()._myText_TurnPrepTime.gameObject.SetActive (true);

		Instance()._myText_TurnTime.text 	= "" + GameConfig.turnTime;
		Instance()._myText_TurnPrepTime.text= "" + GameConfig.turnPreparationTime;

		if (Instance ()._myActiveHero != null)
			Instance ()._myText_PlayerName.text	= "" + Instance ()._myActiveHero.GetName ();
		else
			Instance ()._myText_PlayerName.text	= "CADE HEROI?";

		Instance ()._myActiveHero = null;

		Instance ()._myCurrTurnPrepTime = GameConfig.turnPreparationTime;
		Instance ()._myCurrTurnTime 	= GameConfig.turnTime;

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
			Instance ()._myActiveHero = ((GameObject)(Instance ()._myHeroActionOrder [0])).GetComponent<HeroController> ();
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
			Instance ()._myHeroActionOrder.RemoveAt (0);
			Instance ()._myHeroActionOrder.Add (Instance ()._myActiveHero.gameObject);
			Debug.Log ("PLAYER COUNT " + Instance ()._myHeroActionOrder.Count + "/" + GameConfig.characterAmount);
			BeginTurn ();
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
	private int				_myCurrTurnPrepTime	= 5;
	private int				_myCurrTurnTime		= 30;
		
	#endregion

	UnityEngine.UI.Text _myText_TurnTime;
	UnityEngine.UI.Text _myText_TurnPrepTime;
	UnityEngine.UI.Text _myText_PlayerName;

	void Start()
	{
		Instance()._myText_TurnTime		= GameObject.Find ("<TurnTime>").GetComponent<UnityEngine.UI.Text>();
		Instance()._myText_TurnPrepTime	= GameObject.Find ("<TurnBegins>").GetComponent<UnityEngine.UI.Text>();
		Instance()._myText_PlayerName	= GameObject.Find ("<PlayerName>").GetComponent<UnityEngine.UI.Text>();

		Array.Sort (GameConfig.selectedClasses);
		Instance ()._myHeroActionOrder = new ArrayList ();

		for (int i = 0; i < GameConfig.characterAmount; i++) {
			Debug.Log ("CHAR " + GameConfig.selectedClasses [i]);
			GameObject go = GameObject.Instantiate (HeroPrefabs [GameConfig.selectedClasses [i]]);
			go.GetComponent<HeroController> ().Initialise ();
			Instance ()._myHeroActionOrder.Add (go);
			go.transform.position = GameObject.Find ("SpawnPointPlayer" + (i+1)).transform.position;
		}

		BeginTurn ();
	}
}
