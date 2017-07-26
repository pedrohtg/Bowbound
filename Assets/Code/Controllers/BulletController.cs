using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletController : MonoBehaviour {

	public static GroundController groundController; //controlador do terreno
	protected Vector2 dir;
	protected float speed;
	protected Vector2 currDir;
	public int dmg;
	public float windEffect; // 0 até 1
	public float weight;
	public int radius;
	public Prime31.CharacterController2D ch;
	public abstract void Move();
	public abstract void HitHero(HeroController hero);
	public abstract void HitGround();
	public abstract void Initialize(Vector2 dir,float speed);
	protected void Destoy()
	{
		Destroy(this.gameObject);	
	}
	// Update is called once per frame
	void Update () 
	{
		Move();	
	}
}
