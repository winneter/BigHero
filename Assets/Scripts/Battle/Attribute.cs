﻿using UnityEngine;
using System.Collections;

public class Attribute  {

	public string name;

	public int type;

	private float _maxHp;

	public float maxHp{
		set{
			this._maxHp = value;
		}
		get{
			return this._maxHp + this.addhp * (this.level - 1);
		}
	}
	

	public float hp;

	private int _atk;

	public int atk{
		set{
			this._atk = value;
		}
		get{
			return this._atk + this.addatk * (this.level - 1);
		}

	}

	public int nskill;

	public int sskill;

	public int equip;

	public int addhp;

	public int addatk;

	public int crit;

	public int opentype;

	public int opennum;

	public int need;

	public int mod;

	public string description;

	public int level = 1;

	public int volume = 1;

}
