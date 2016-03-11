using UnityEngine;
using System.Collections;

public class Couvercle : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(waitForCollider(other));
            //other.isTrigger = false;
        }
    }

    IEnumerator waitForCollider(Collider col)
    {

        yield return new WaitForSeconds(17f / col.GetComponent<Rigidbody>().velocity.magnitude);
        Debug.LogWarning("caca");
        col.isTrigger = false;
    }
}
