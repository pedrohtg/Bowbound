using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.LogWarning ("Quero pegar blablaba");	

		if (Application.platform == RuntimePlatform.LinuxEditor || Application.platform == RuntimePlatform.LinuxPlayer) {
			Debug.LogWarning ("Estou no linux!");
		} else if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer) {
			Debug.LogWarning ("Estou no windows!");
		} else if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer) {
			Debug.LogWarning ("Estou no OSX!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static bool IsUnix()	{
		var platform = (int)System.Environment.OSVersion.Platform;
		return (platform == 4) || (platform == 6) || (platform == 128);
	}
}
