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

	// Use this for initialization
	void Start () {
		circle = GameObject.Instantiate(circle);
		btLimiter = GameObject.Instantiate(btLimiter);
		upLimiter = GameObject.Instantiate(upLimiter);
		aim = GameObject.Instantiate(aim);
	}
	
	// Update is called once per frame
	void Update () {
		if (hide) {
			Hide ();
		} 
		else {
			if (updateOnlyAim) {
				aim.transform.localEulerAngles = new Vector3 (0, 0, aimAng);
				aim.GetComponent<SpriteRenderer>().enabled = true;
			}
			if (show) {
				Show ();		
			}
		}
	}

	public void Hide(){
		circle.transform.position = circleCenter;
		circle.GetComponent<SpriteRenderer>().enabled = false;

		btLimiter.transform.localEulerAngles = new Vector3 (0, 0, btLimiterAng);
		btLimiter.GetComponent<SpriteRenderer>().enabled = false;

		upLimiter.transform.localEulerAngles = new Vector3 (0, 0, upLimiterAng);
		upLimiter.GetComponent<SpriteRenderer>().enabled = false;

		aim.transform.localEulerAngles = new Vector3 (0, 0, aimAng);
		aim.GetComponent<SpriteRenderer>().enabled = false;
	}

	public void Show(){
		circle.transform.position = circleCenter;
		circle.GetComponent<SpriteRenderer>().enabled = true;

		btLimiter.transform.localEulerAngles = new Vector3 (0, 0, btLimiterAng);
		btLimiter.GetComponent<SpriteRenderer>().enabled = true;

		upLimiter.transform.localEulerAngles = new Vector3 (0, 0, upLimiterAng);
		upLimiter.GetComponent<SpriteRenderer>().enabled = true;

		aim.transform.localEulerAngles = new Vector3 (0, 0, aimAng);
		aim.GetComponent<SpriteRenderer>().enabled = true;


		show = false;
		updateOnlyAim = true;

	}

	public void SetAimAng(float ang){
		Debug.Log (ang);
		aimAng = ang * Mathf.Rad2Deg;
		Debug.Log (aimAng);
		aim.transform.eulerAngles = new Vector3 (0, 0, aimAng);
		show = true;
	}

	public void SetBtLimiterAng(float ang){
		btLimiterAng = ang * Mathf.Rad2Deg;
		btLimiter.transform.localEulerAngles = new Vector3 (0, 0, ang * Mathf.Rad2Deg);
		show = true;
	}

	public void SetUpLimiterAng(float ang){
		upLimiterAng = ang * Mathf.Rad2Deg;
		upLimiter.transform.localEulerAngles = new Vector3 (0, 0, ang * Mathf.Rad2Deg);
		show = true;
	}

}
