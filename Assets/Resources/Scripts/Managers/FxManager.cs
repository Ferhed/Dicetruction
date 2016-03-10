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
    public GameObject lightning;
    public GameObject vortex;

    public void LaunchFX(GameObject FX, Vector3 position, Vector3 rotate)
    {
        GameObject go = Instantiate(FX, position, Quaternion.identity) as GameObject;
        if (FX == earthquake)
        {
            go.transform.eulerAngles = new Vector3(-90, 0, 0);
        }
        else if (FX == lightning)
        {
            go.transform.eulerAngles = rotate;
        }
        Destroy(go, 3f);
    }
    public void LaunchFX(GameObject FX, Vector3 position, Quaternion rotate)
    {
        GameObject go = Instantiate(FX, position, Quaternion.identity) as GameObject;
        if (FX == earthquake)
        {
            go.transform.eulerAngles = new Vector3(-90, 0, 0);
        }
        else if (FX == lightning)
        {
            go.transform.rotation = rotate;
        }
        Destroy(go, 3f);
    }
}
