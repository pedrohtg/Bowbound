using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimController : MonoBehaviour {

	public GameObject circle;
	public GameObject btLimiter;
	public GameObject upLimiter;
	public GameObject aim;

	private Vector3 circleCenter;
	private float btLimiterAng;
	private float upLimiterAng;
	private float aimAng;

	public bool hide = false;
	public bool show = false;
	public bool updateOnlyAim = false;

	void Start()
	{
		upLimiter.transform.eulerAngles = new Vector3 (0.0f, 0.0f, GameConfig.maxAngle);
	}

	public void Hide()
	{
		//Debug.Log ("HIDE AIM!!! ");
		circle.SetActive (false);
		btLimiter.SetActive (false);
		upLimiter.SetActive (false);
		aim.SetActive (false);
	}

	public void Show()
	{
		//Debug.Log ("SHOW AIM!!! ");
		circle.SetActive (true);
		btLimiter.SetActive (true);
		upLimiter.SetActive (true);
		aim.SetActive (true);
	}

	public void FaceRight()
	{
		upLimiter.transform.eulerAngles = new Vector3 (0.0f, 0.0f, GameConfig.maxAngle);
		btLimiter.transform.eulerAngles = new Vector3 (0.0f, 0.0f, 0.0f);
	}

	public void FaceLeft()
	{
		upLimiter.transform.eulerAngles = new Vector3 (0.0f, 0.0f, 180.0f - GameConfig.maxAngle);
		btLimiter.transform.eulerAngles = new Vector3 (0.0f, 0.0f, 180.0f);
	}

	public void SetAimAng(float ang)
	{
		Debug.Log (ang);
		aimAng = ang * Mathf.Rad2Deg;
		Debug.Log (aimAng);
		aim.transform.eulerAngles = new Vector3 (0, 0, aimAng);
		show = true;
	}

	public void SetBtLimiterAng(float ang)
	{
		btLimiterAng = ang * Mathf.Rad2Deg;
		btLimiter.transform.localEulerAngles = new Vector3 (0, 0, ang * Mathf.Rad2Deg);
		show = true;
	}

	public void SetUpLimiterAng(float ang)
	{
		upLimiterAng = ang * Mathf.Rad2Deg;
		upLimiter.transform.localEulerAngles = new Vector3 (0, 0, ang * Mathf.Rad2Deg);
		show = true;
	}

}
