﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BombeH : Destruction
{
	public float radius;

	public BombeH (float radius, int energy, float force) : base (energy, "BombeH", force)
	{
		this.radius = radius;
	}

	public BombeH (float radius, int energy, float force, Sprite image) : base (energy, "BombeH", force, image)
	{
		this.radius = radius;
        m_type = CardType.SingleDie;
    }

	public override void Cast (List<GameObject> targets)
	{
        for(int i = 0; i<targets.Count;i++)
        {
		    GameObject dice = targets [i];
		    Collider[] co = Physics.OverlapSphere (dice.transform.position, 15f);
            Debug.Log("Length = "+co.Length);
            foreach (Collider currentCo in co)
            {
                if (currentCo.tag == "needPhysics")
                {
                    currentCo.GetComponent<Building>().bump();
                    currentCo.GetComponent<Building>().changeWeight();
                    currentCo.GetComponent<Rigidbody>().AddExplosionForce(350f * 100 * 1, dice.transform.position, 15f);
                }
                dice.GetComponent<Rigidbody>().AddExplosionForce(450f, dice.transform.position, 15f);
            }
		}
		XInput.instance.useVibe (0, 0.5f, 1, 1);
        SoundManager.Instance.PlayMonoSound(SoundManager.Instance.s_keepCalmBomb, 1f);
    }

	public override Card Copy ()
	{
		return new BombeH (radius, energy, force, m_image);
	}
}
