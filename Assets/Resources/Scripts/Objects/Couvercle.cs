using UnityEngine;
using System.Collections;

public class Couvercle : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Collider>().isTrigger = false;
        }
    }
}
