﻿using UnityEngine;
using System.Collections;

public class Charactor : MonoBehaviour {

	public virtual Attribute GetAttribute(){return null;}

	public virtual MoveDirection GetDirection(){return MoveDirection.UP;}

	public virtual void ChangeHP(float hp){}

	public virtual void StopMoving(){}
	
	public virtual void PlayMoving(){}

	public virtual void PlayAttack(){}

	public virtual void PlayAttacked(){}

	public virtual void PlayDead(){}

	public virtual bool IsInAttIndex(){return false;}
}
