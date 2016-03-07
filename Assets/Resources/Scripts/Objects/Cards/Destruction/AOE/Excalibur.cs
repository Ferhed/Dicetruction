using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Excalibur : Destruction
{

    public float radius;

    public Excalibur(float radius, int energy, float force, Sprite image) : base (energy, "Excalibur", force, image)
    {
        this.radius = radius;
    }

    public override void Cast(List<GameObject> targets)
    {

    }

    public override Card Copy()
    {
        return new Excalibur(radius, energy, force, m_image);
    }
}
