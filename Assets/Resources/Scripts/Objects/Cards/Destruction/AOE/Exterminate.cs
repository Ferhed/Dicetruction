using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Exterminate : Destruction
{
    public float radius;

    public Exterminate(float radius, int energy, float force, Sprite image) : base (energy, "Exterminate", force, image)
    {
        this.radius = radius;
    }

    public override void Cast(List<GameObject> targets)
    {

    }

    public override Card Copy()
    {
        return new Exterminate(radius, energy, force, m_image);
    }
}
