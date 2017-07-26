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
		this.currTime=0;
	}
	public override void Move()
	{
		float t=currTime;
		float t2=t*t;
		float deltaTime=Time.deltaTime;
		Vector2 wind=GameController.Wind();
		float pxt_last=dir.x*speed*t+0.5f*windEffect*wind.x*t2;
		float pyt_last=dir.y*speed*t+0.5f*(windEffect*wind.y)*t2-0.5f*(weight)*t2;
		t=t+deltaTime;
		t2=t*t;
		float pxt_new=dir.x*speed*t+0.5f*windEffect*wind.x*t2;
		float pyt_new=dir.y*speed*t+0.5f*(windEffect*wind.y)*t2-0.5f*(weight)*t2;
		currDir=new Vector2(pxt_new-pxt_last,pyt_new-pyt_last);
		ch.move(currDir);
		currTime=t;
		if(t > 3f) Destoy();
	}
	public override void HitHero(HeroController hero)
	{
		hero.TakeDamage(dmg);
		//Invoke("Destoy()",0.2f);
		Destoy();
	}
	public override void HitGround(Vector2 point)
	{
		groundController.DestroyGround(point,radius);
		Destoy();
		//Invoke("Destoy()",0.2f);
	}
	void Update () 
	{
		Move();
		Vector2 newDir=currDir.normalized;
		float ang=Mathf.Asin(newDir.y)*Mathf.Rad2Deg;
		if(newDir.x<0f)ang=180-ang;
		//sprite.transform.Rotate(new Vector3(0,0,ang));
		//sprite.transform.LookAt(new Vector3(0,0,ang));
		sprite.transform.localEulerAngles=new Vector3(0,0,ang);
	}



}
