/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : HeroController {

	public static int Health = 200;
	public static int Speed = 5;
	public static float DmgCausedMultiplier = .6f;
	public static float DmgReceivedMultiplier = .4f;

	public static int RequiredEnergyForSkill2 = 40;
	public static int RequiredEnergyForSkill3 = 60;
	public static int RequiredEnergyForSkill4 = 100;

	//Initialise
	public void Initialise(){
		_health = Health;
		_energy = 0;
		_speed = Speed;
		_dir = true;
		_dmgCausedMultiplier = DmgCausedMultiplier;
		_dmgReceivedMultiplier = DmgReceivedMultiplier;
		_angle = 0;
		_launchForce = 0;
		ch = new CharacterController ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool CanUseSkill2(){
		return _energy >= RequiredEnergyForSkill2;
	}


	public bool CanUseSkill3(){
		return _energy >= RequiredEnergyForSkill3;
	}


	public bool CanUseSkill4(){
		return _energy >= RequiredEnergyForSkill4;
	}



}
*/