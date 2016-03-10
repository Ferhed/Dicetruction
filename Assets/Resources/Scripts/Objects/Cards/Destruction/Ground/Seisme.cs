using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Seisme : Destruction
{

	public Seisme (int energy, float force, Sprite image) : base (energy, "Seisme", force, image)
    {
        m_type = CardType.NoDie;
    }

	public override void Cast (List<GameObject> targets)
    {
        //FxManager.Instance.LaunchFX(FxManager.Instance.earthquake, new Vector3(0, 0, 0));
    }

	public override Card Copy ()
	{
		return new Seisme (energy, force, m_image);
	}

	public IEnumerator yollohSeisme ()
	{

		GameObject ground = GameObject.FindGameObjectWithTag ("Ground");
        SoundManager.Instance.PlayMonoSound(SoundManager.Instance.s_earthQuake, 1f);
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
