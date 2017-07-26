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
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hide) {
			Hide ();
		} 
		else {
			if (updateOnlyAim) {
				aim.transform.localEulerAngles = new Vector3 (0, 0, aimAng);
				(aim.GetComponent (typeof(SpriteRenderer)) as SpriteRenderer).enabled = true;
			}
			if (show) {
				Show ();		
			}
		}
	}

	public void Hide(){
		circle.transform.position = circleCenter;
		(circle.GetComponent (typeof(SpriteRenderer)) as SpriteRenderer).enabled = false;

		btLimiter.transform.localEulerAngles = new Vector3 (0, 0, btLimiterAng);
		(btLimiter.GetComponent (typeof(SpriteRenderer)) as SpriteRenderer).enabled = false;

		upLimiter.transform.localEulerAngles = new Vector3 (0, 0, upLimiterAng);
		(upLimiter.GetComponent (typeof(SpriteRenderer)) as SpriteRenderer).enabled = false;

		aim.transform.localEulerAngles = new Vector3 (0, 0, aimAng);
		(aim.GetComponent (typeof(SpriteRenderer)) as SpriteRenderer).enabled = false;
	}

	public void Show(){
		//circle.transform.position = circleCenter;
		(circle.GetComponent (typeof(SpriteRenderer)) as SpriteRenderer).enabled = true;

		btLimiter.transform.localEulerAngles = new Vector3 (0, 0, btLimiterAng);
		(btLimiter.GetComponent (typeof(SpriteRenderer)) as SpriteRenderer).enabled = true;

		upLimiter.transform.localEulerAngles = new Vector3 (0, 0, upLimiterAng);
		(upLimiter.GetComponent (typeof(SpriteRenderer)) as SpriteRenderer).enabled = true;

		aim.transform.localEulerAngles = new Vector3 (0, 0, aimAng);
		(aim.GetComponent (typeof(SpriteRenderer)) as SpriteRenderer).enabled = true;


		show = false;
		updateOnlyAim = true;

	}

	public void SetAimAng(float ang){
		aimAng = ang * Mathf.Rad2Deg;
		aim.transform.localEulerAngles = new Vector3 (0, 0, ang * Mathf.Rad2Deg);
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
