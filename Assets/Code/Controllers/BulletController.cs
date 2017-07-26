using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletController : MonoBehaviour {

	public static GroundController groundController; //controlador do terreno
	protected Vector2 dir;
	protected float speed;
	protected Vector2 currDir;
	public GameObject sprite;
	public int dmg;
	public float windEffect; // 0 até 1
	public float weight;
	public int radius;
	protected float currTime;
	public Prime31.CharacterController2D ch;
	public abstract void Move();
	public abstract void HitHero(HeroController hero);
	public abstract void HitGround(Vector2 point);
	public abstract void Initialize(Vector2 dir,float speed);
	public void Destoy()
	{
		Destroy(this.gameObject);	
	}
	// Update is called once per frame
	void Update () 
	{
		Move();	
	}

	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log("HIT");
		if(collision.collider.name == "GroundObject"){
			Vector2 Point = new Vector2();
			for(int i = 0; i < collision.contacts.Length; i++){
				Point += collision.contacts[i].point;
			}
			Point.x /= collision.contacts.Length;
			Point.y /= collision.contacts.Length;
			HitGround(Point);
		}
		else if(collision.collider.name == "Player"){
			Debug.Log("player");
		}
		else{
			Debug.Log("OBJECT");
		}
	}

}
