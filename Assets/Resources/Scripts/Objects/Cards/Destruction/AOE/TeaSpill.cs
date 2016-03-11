using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TeaSpill : Destruction
{

    public float radius;

    public TeaSpill(float radius, int energy, float force, Sprite image) : base(energy, "TeaSpill", force, image)
    {
        this.radius = radius;
    }

    public override void Cast(List<GameObject> targets)
    {
        GameObject dice = targets[0];
        Collider[] co = Physics.OverlapSphere(dice.transform.position, 15f);
        Debug.Log("Length = " + co.Length);
        foreach (Collider currentCo in co)
        {
            if (currentCo.tag == "needPhysics" && currentCo.name == "RDC")
            {
                currentCo.GetComponent<Building>().bump();
                currentCo.GetComponent<Building>().changeWeight();
                currentCo.GetComponent<Rigidbody>().AddExplosionForce(350f * 500 * 1, dice.transform.position, 150f);
            }
        }
        XInput.instance.useVibe(0, 0.5f, 1, 1);
        SoundManager.Instance.PlayMonoSound(SoundManager.Instance.s_teaSpill, 1f);
        FxManager.Instance.LaunchFX(FxManager.Instance.earthquake, targets[0].transform.position, Quaternion.identity);
    }


    public override Card Copy()
    {
        return new TeaSpill(radius, energy, force, m_image);
    }
}
