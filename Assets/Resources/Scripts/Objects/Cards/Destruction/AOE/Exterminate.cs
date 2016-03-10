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
        GameObject selectedDice = targets[0];
        GameObject farDice = SelectDices(TurnManager.instance.currentPlayer.GODices, selectedDice);

        RaycastHit[] co = Physics.BoxCastAll(selectedDice.transform.position,
            selectedDice.transform.localScale,
            farDice.transform.position-selectedDice.transform.position,
            selectedDice.transform.rotation,
            Vector3.Distance(selectedDice.transform.position,farDice.transform.position));
        foreach (RaycastHit currentCo in co)
        {
            if (currentCo.collider.tag == "needPhysics" ||currentCo.collider.tag == "Props")
            {
                currentCo.collider.GetComponent<Building>().bump();
                currentCo.collider.GetComponent<Building>().changeWeight();
                currentCo.collider.GetComponent<Rigidbody>().AddExplosionForce(350f * 1000 * 1, currentCo.transform.position + Vector3.right, 10 );
            }
        }

        Vector3 dir = farDice.transform.position - selectedDice.transform.position;
        float Phi = Mathf.Acos(dir.y / dir.magnitude) * 180 / Mathf.PI;
        float Teta = Mathf.Atan2(selectedDice.transform.position.z, selectedDice.transform.position.x) * 180 / Mathf.PI;

        FxManager.Instance.LaunchFX(FxManager.Instance.lightning, targets[0].transform.position, new Vector3(Phi - 90,   Teta, 0));
    }

    GameObject SelectDices(GameObject[] dices, GameObject selectedDice)
    {
        float[] dists = new float[3];
        dists[0] = Vector3.Distance(selectedDice.transform.position, dices[0].transform.position);
        dists[1] = Vector3.Distance(selectedDice.transform.position, dices[1].transform.position);
        dists[2] = Vector3.Distance(selectedDice.transform.position, dices[2].transform.position);
        if (dists[0] > dists[1] && dists[0] > dists[2])
        {
            return dices[0];
        }
        else if (dists[1] > dists[2])
        {

            return dices[1];
        }
        else
        {

            return dices[2];
        }
    }

    public override Card Copy()
    {
        return new Exterminate(radius, energy, force, m_image);
    }
}
