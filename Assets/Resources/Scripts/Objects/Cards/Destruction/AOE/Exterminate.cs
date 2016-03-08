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
        GameObject dice1 = targets[0];
        GameObject dice2 = targets[1];
        RaycastHit[] co = Physics.BoxCastAll(dice1.transform.position, dice1.transform.localScale, dice2.transform.position-dice1.transform.position);
        Debug.Log("Length = " + co.Length);
        foreach (RaycastHit currentCo in co)
        {
            if (currentCo.collider.tag == "needPhysics")
            {
                currentCo.collider.GetComponent<Building>().bump();
                currentCo.collider.GetComponent<Building>().changeWeight();
                currentCo.collider.GetComponent<Rigidbody>().AddExplosionForce(350f * 1000 * 1, currentCo.transform.position, 10 );
            }
        }
    }

    public override Card Copy()
    {
        return new Exterminate(radius, energy, force, m_image);
    }
}
