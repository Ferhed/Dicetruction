using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BuildManager : MonoBehaviour {

    static BuildManager instance;
    public static BuildManager Instance
    {
        get
        {
            return instance;
        }
    }
    public List<Rigidbody> buildingInMovement;
    public bool buildingStatic = true;
    public float timeEndTurn = 15f;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        buildingInMovement = new List<Rigidbody>();
    }

    public void addElement(Rigidbody element)
    {
        if (buildingInMovement.Count == 0)
        {
            buildingInMovement.Add(element);
            StartCoroutine(CheckBuilding());
        }
        if (!buildingInMovement.Contains(element))
            buildingInMovement.Add(element);
    }

    IEnumerator goToEnd()
    {
        yield return new WaitForSeconds(timeEndTurn);

        buildingInMovement.Clear();
        buildingStatic = true;

        yield return null;
    }

    IEnumerator CheckBuilding()
    {
        buildingStatic = false;
        while (buildingInMovement.Count > 0) {
            for (int i = 0; i < buildingInMovement.Count; i++)
            {
                if (i % 10 == 0)
                    yield return null;
                if (buildingInMovement[i] == null)
                {
                    buildingInMovement.RemoveAt(i);
                    i--;
                    continue;
                }
                if( buildingInMovement[i].velocity.sqrMagnitude <= 0.5f || buildingInMovement[i].transform.position.magnitude >= 1000 )
                {
                    if(buildingInMovement[i].name == "RDC")
                    {
                        buildingInMovement[i].GetComponent<Building>().checkPosition();
                    }
                    buildingInMovement.RemoveAt(i);
                    i--;
                }

                yield return null;
            }
        }
        buildingStatic = true;
    }

}
