using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Excalibur : Destruction
{

    public float radius;

    public Excalibur(float radius, int energy, float force, Sprite image) : base(energy, "Excalibur", force, image)
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
            if (currentCo.tag == "needPhysics" && currentCo.name == "FirstFloor")
            {
                currentCo.GetComponent<Building>().bump();
                currentCo.GetComponent<Building>().changeWeight();
                currentCo.GetComponent<Rigidbody>().AddExplosionForce(350f * 500 * 1, dice.transform.position, 150f);
                Debug.Log("AfterExplosion");
            }
        }
    }
     
    public override Card Copy()
    {
        return new Excalibur(radius, energy, force, m_image);
    }
}
