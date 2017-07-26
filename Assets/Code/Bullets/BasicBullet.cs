using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBullet : BulletController 
{
	public override void Initialize(Vector2 dir,float speed)
	{
		this.dir=dir;
		this.speed=speed;
		this.currDir=dir*speed;
	}
	public override void Move()
	{
		Vector3 vec=new Vector3();
		vec.x=currDir.x;
		vec.y=currDir.y;
		ch.move(vec);
		Vector2 wind=GameController.Wind();
		currDir.x+=Time.deltaTime*windEffect*wind.x;
		currDir.y+=Time.deltaTime*(windEffect*wind.y-weight);
	}
	public override void HitHero(HeroController hero)
	{
		hero.TakeDamage(dmg);
		Invoke("Destoy()",0.2f);
	}
	public override void HitGround()
	{
		groundController.DestroyGround(dir,radius); //alterar depois
		Invoke("Destoy()",0.2f);
	}
	void Update () 
	{
		Move();	
	}
}
