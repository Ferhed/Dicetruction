﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Seisme : Destruction
{

	public Seisme (int energy, float force, Sprite image) : base (energy, "Seisme", force, image)
	{

	}

	public override void Cast (List<GameObject> targets)
	{
		
	}

	public override Card Copy ()
	{
		return new Seisme (energy, force, m_image);
	}

	public IEnumerator yollohSeisme ()
	{

		GameObject ground = GameObject.FindGameObjectWithTag ("Ground");
		ground.transform.position -= Vector3.up / 10;
		int up = 1;
		while (up != 10) {
			ground.transform.position += Vector3.up / 100;
			up++;
			yield return new WaitForSeconds (0.05f);
		}


		XInput.instance.useVibe (0, 0.5f, 1, 1);
		yield return null;
	}
}
