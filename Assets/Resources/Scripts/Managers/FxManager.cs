using UnityEngine;
using System.Collections;

public class FxManager : MonoBehaviour {

    static FxManager instance;
    public static FxManager Instance
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
    public GameObject bombeH;
    public GameObject earthquake;

    public void LaunchFX(GameObject FX ,Vector3 position)
    {
        GameObject go = Instantiate(FX, position , Quaternion.identity) as GameObject;
    }
}
