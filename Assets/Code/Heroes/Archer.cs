﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prime31;

public class Archer : HeroController {

	public static int Health = 200;
	public static int Speed = 5;
	public static float DmgCausedMultiplier = .6f;
	public static float DmgReceivedMultiplier = .4f;
	public static float Velocity = 1.0f;

	public static int RequiredEnergyForSkill2 = 40;
	public static int RequiredEnergyForSkill3 = 60;
	public static int RequiredEnergyForSkill4 = 100;

	//Initialise
	public override void Initialise(){
		_name = "Archer";
		_health = Health;
		_energy = 0;
		_speed = Speed;
		_dir = true;
		_dmgCausedMultiplier = DmgCausedMultiplier;
		_dmgReceivedMultiplier = DmgReceivedMultiplier;
		_angle = 0;
		_launchForce = 0;

		_angleSkill [0] = Mathf.Deg2Rad *  90.0f;
		_angleSkill [1] = Mathf.Deg2Rad * 100.0f;
		_angleSkill [2] = Mathf.Deg2Rad * 120.0f; 
		_angleSkill [3] = Mathf.Deg2Rad * 270.0f;

		ch = GetComponent<CharacterController2D> ();
		_velocity = Velocity;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override bool CanUseSkill2(){
		return _energy >= RequiredEnergyForSkill2;
	}


	public override bool CanUseSkill3(){
		return _energy >= RequiredEnergyForSkill3;
	}


	public override bool CanUseSkill4(){
		return _energy >= RequiredEnergyForSkill4;
	}

	public override void UseSkill1(){
		
	}

	public override void UseSkill2(){
		
	}

	public override void UseSkill3(){
		
	}

	public override void UseSkill4(){
		
	}

}
