using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCharacterSelectButton : MonoBehaviour 
{
	public int classIndex;
	public UnityEngine.UI.Button openChar;
	public UnityEngine.UI.Button closedChar;

	public void Open()
	{
		closedChar.gameObject.SetActive (false);
	}

	public void Pick()
	{
		openChar.gameObject.SetActive (false);
		closedChar.gameObject.SetActive (true);
		GameConfig.selectedClasses [GameConfig.characterAmount] = classIndex;
		GameConfig.characterAmount++;
	}
}
