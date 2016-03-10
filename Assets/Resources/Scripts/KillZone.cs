using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
