using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

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
        ground.transform.DOShakePosition(5f, force);

        Collider[] co = Physics.OverlapSphere(Vector3.zero, 120f);
        Debug.Log("Length = " + co.Length);
        foreach (Collider currentCo in co)
        {
            if (currentCo.tag == "needPhysics" || currentCo.tag == "Props")
            {
                currentCo.GetComponent<Building>().bump();
            }
        }

        XInput.instance.useVibe (0, 0.5f, 1, 1);
		yield return null;
	}
}
