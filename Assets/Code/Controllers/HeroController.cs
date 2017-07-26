using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HeroController : MonoBehaviour {
	//DIRECTION CONSTANTS
	const bool LEFT = true;
	const bool RIGHT = false;
	const bool UP = true;
	const bool DOWN  = false;

	public static float _angleIncrease = 50.0f;
	public static float _forceIncrease = 2.5f;
	public static int _maxEnergy = 100;

	protected bool _dir;
	protected int _health, _energy, _speed;
	protected float _dmgCausedMultiplier, _dmgReceivedMultiplier, _velocity;
	protected float _angle, _launchForce;
	protected int _skill = 1;
	protected string _name = "NULL";

	public CharacterController ch;

	public abstract void Initialise ();

	public string GetName()
	{
		return _name;
	}

	public void Walk(bool dir)
	{	
		if (dir == LEFT) 
		{
			_dir = LEFT;
			ch.Move(new Vector3(-_velocity, 0, 0));
		} 
		else 
		{
			_dir = RIGHT;
			ch.Move(new Vector3(_velocity, 0, 0));	
		}
	}

	public void ChangeAngle(bool dir)
	{
		float increase = _angleIncrease;
		if (dir == UP) 
		{
			_angle += increase * Time.deltaTime;
			_angle = Mathf.Min (_angle, Mathf.PI / 2.0f);
		} 
		else 
		{
			_angle -= increase * Time.deltaTime;
			_angle = Mathf.Max (_angle, 0.0f);
		}
	}

	public void ChangeLaunchForce()
	{
		_launchForce += _forceIncrease * Time.deltaTime;
		_launchForce = Mathf.Min (_launchForce, 1.0f);

	}

	public abstract bool CanUseSkill2 ();
	public abstract bool CanUseSkill3 ();
	public abstract bool CanUseSkill4 ();

	public abstract bool UseSkill1 ();
	public abstract bool UseSkill2 ();
	public abstract bool UseSkill3 ();
	public abstract bool UseSkill4 ();


	public void Attack()
	{
		switch (_skill) 
		{
		case 1:
			UseSkill1 ();
			break;
		case 2:
			if (CanUseSkill2 ()) 
			{
				UseSkill2 ();
			}
			break;
		case 3:
			if (CanUseSkill3 ()) 
			{
				UseSkill3 ();
			}
			break;
		case 4:
			if (CanUseSkill4 ()) 
			{
				UseSkill4 ();
			}
			break;
		default:
			break;
		}
	}

	public void ChangeSkill(int skill)
	{
		_skill = skill;
	}

	public void IncreaseEnergy(int dmg)
	{
		_energy += (int)((float)dmg * _dmgCausedMultiplier);
		_energy = Mathf.Min (_energy, _maxEnergy);
	}

	public void TakeDamage(int dmg)
	{
		_health -= dmg;
		_energy += (int)((float)dmg * _dmgReceivedMultiplier);
		_energy = Mathf.Min (_energy, _maxEnergy);

		GameController.ActiveHero().IncreaseEnergy(dmg);

		if (_health <= 0) 
		{
			Death ();
		}

	}

	public void Death()
	{
		Debug.Log ("Morri.");
		GameController.Kill (this);
	}


}
