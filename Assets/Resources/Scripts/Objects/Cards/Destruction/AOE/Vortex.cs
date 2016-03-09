﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Vortex : Destruction
{
	public float radius;

	public Vortex (float radius, int energy, float force, Sprite image) : base (energy, "Seisme", force, image)
	{
		this.radius = radius;
        m_type = CardType.SingleDie;
    }

	public override void Cast (List<GameObject> targets)
	{
		GameObject dice = targets [0];

		Collider[] co = Physics.OverlapSphere (dice.transform.position, 15f);
		foreach (Collider currentCo in co) {
			if (currentCo.tag == "needPhysics" ||currentCo.tag == "Props") {
				currentCo.GetComponent<Building> ().bump ();
				currentCo.GetComponent<Building> ().changeWeight ();
				currentCo.GetComponent<Rigidbody> ().AddExplosionForce (-350f * 400 * force, dice.transform.position, 15f);
			}
		}
		XInput.instance.useVibe (0, 0.5f, 1, 1);
		dice.GetComponent<Rigidbody> ().AddExplosionForce (450f, dice.transform.position, 15f);
        SoundManager.Instance.PlayMonoSound(SoundManager.Instance.s_vortex, 1f);

	}

	public override Card Copy ()
	{
		return new Vortex (radius, energy, force, m_image);
	}
}
