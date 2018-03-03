﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseObject : MonoBehaviour {

    public int HP;
    public bool isRepared;
    public int maxHP;
    public float repareCooldown;
    public Collider repareCollider;
    public float baseHeight;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void Destroy()
    {
        HP = 0;
        isRepared = false;
    }

    public virtual void Rotate(int angle)
    {
        gameObject.transform.Rotate(new Vector3(0, angle, 0));
    }

    public virtual void Repare()
    {
        if (repareCooldown <= 0 && !isRepared)
        {
            HP += 10;
            repareCooldown = 1;
            if (HP == maxHP)
                isRepared = true;
        }
    }
}