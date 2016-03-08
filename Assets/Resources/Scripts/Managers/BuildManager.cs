﻿using UnityEngine;
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
    public List<GameObject> buildingInMovement;
    public bool buildingStatic = true;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if (buildingInMovement.Count == 0)
        {
            buildingStatic = false;
        }
        buildingInMovement = new List<GameObject>();
    }

    public void addElement(GameObject element)
    {
        if(!buildingInMovement.Contains(element))
            buildingInMovement.Add(element);
    }

    public void delElement(GameObject element)
    {
        buildingInMovement.Remove(element);
        if(buildingInMovement.Count == 0)
        {
            buildingStatic = true;
        }
    }



}
