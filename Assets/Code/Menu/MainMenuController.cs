using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour 
{
	public UnityEngine.UI.Text inputText;
	public UnityEngine.UI.Text turnTimeText;
	public UnityEngine.UI.Text turnTimePrepText;

	public UnityEngine.UI.Text playerAmount;
	public UnityEngine.UI.Text currentPlayer;

	public UnityEngine.UI.Button startGameButton;

	void Start()
	{
		startGameButton.gameObject.SetActive (false);
		MainMenuCharacterSelectButton[] m = GameObject.FindObjectsOfType<MainMenuCharacterSelectButton> ();
		foreach (MainMenuCharacterSelectButton b in m) 
		{
			b.Open ();
		}
		GameConfig.ResetGame ();
	}

	void Update()
	{
		if(GameConfig.characterAmount > 1)
			startGameButton.gameObject.SetActive (true);
		else
			startGameButton.gameObject.SetActive (false);

		currentPlayer.text 	= "Selecione um Herói para o jogador " + (GameConfig.characterAmount + 1);
	}

	public void SelectInput()
	{
		GameConfig.useJoystick = !GameConfig.useJoystick;

		if (GameConfig.useJoystick) 
		{
			inputText.text = "Manete";
		}
		else 
		{
			inputText.text = "Teclado";
		}

	}

	public void SelectTurnTime()
	{
		GameConfig.turnTime = (GameConfig.turnTime + 10) % GameConfig.maxTurnTime;
		if (GameConfig.turnTime == 0)
			GameConfig.turnTime = 10;
		turnTimeText.text = "" + GameConfig.turnTime;
	}

	public void SelectTurnTimePrep()
	{
		GameConfig.turnPreparationTime = (GameConfig.turnPreparationTime + 2) % GameConfig.maxTurnPreparationTime;
		turnTimePrepText.text = "" + GameConfig.turnPreparationTime;
	}
}
