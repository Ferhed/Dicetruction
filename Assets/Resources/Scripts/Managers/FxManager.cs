using UnityEngine;
using System.Collections;

public class FxMAnager : MonoBehaviour {

    static FxMAnager instance;
    public static FxMAnager Instance
    {
        get
        {
            return instance;
        }
    }
    void Awake()
    {
        instance = this;
    }

    public GameObject explosion;
    public GameObject vortex;


    public void LaunchFX(GameObject FX ,Vector3 position)
    {
        GameObject go = Instantiate(FX, position , Quaternion.identity) as GameObject;
    }
}
