using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tilt : Support
{
    float force;

    public Tilt(int energy, float force, Sprite image) : base(energy, "Tilt", image)
    {
        this.force = force;
        m_type = CardType.SingleDie;
    }

    public override void Cast(List<GameObject> targets)
    {
        GameObject dice = targets[0];

        float X = Random.Range(-1f, 1f);
        float Z = Random.Range(-1f, 1f);
        Vector3 displacment = new Vector3(X, 0, Z);
        displacment.Normalize();
        dice.GetComponent<Rigidbody>().AddForce((displacment + Vector3.up) * 200 * force);
        Debug.Log(displacment);
        XInput.instance.useVibe(0, 0.5f, 1, 1);
    }

    public override Card Copy()
    {
        return new Tilt(energy, force, m_image);
    }
}
