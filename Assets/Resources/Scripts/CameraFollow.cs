using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public Transform startMarker;
	public GameObject[] dices;
	private Vector3 endMarker;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	private float height = 10;
	private Vector3 middle;
	Vector3 direction;

	void Start() {
		startTime = Time.time;
		SelectDices();
		getMiddleOfThree();
		journeyLength = Vector3.Distance(startMarker.position, endMarker);
	}
	void Update() {
        SelectDices();
        getMiddleOfThree();
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(transform.position, endMarker, fracJourney);
        //transform.rotation = new Quaternion(transform.rotation.x, 0, transform.rotation.z, transform.rotation.w);
        Vector3 dir = middle - transform.position;
        float Phi = Mathf.Acos(transform.position.y / dir.magnitude) * 180 / Mathf.PI;
        float Teta = Mathf.Atan2(transform.position.z, transform.position.x) * 180 / Mathf.PI;
        transform.eulerAngles = new Vector3(90 - Phi, 90 - Teta, 0);
    }

	void getMiddleOfThree()
	{
        middle = (dices[0].transform.position + dices[1].transform.position + dices[2].transform.position) / 3;
        endMarker = middle + Vector3.up * 1.3f * height;

    }
	
	void SelectDices()
	{
        float[] dists = new float[3];
        dists[0] = Vector3.Distance(dices[0].transform.position, dices[1].transform.position);
        dists[1] = Vector3.Distance(dices[2].transform.position, dices[1].transform.position);
        dists[2] = Vector3.Distance(dices[2].transform.position, dices[0].transform.position);
        if (dists[0] > dists[1] && dists[0] > dists[2])
        {
            height = Mathf.Max(dists[0], 20f);
            //direction = new Vector3(middle.x - dices[2].transform.position.x, 0, middle.z - dices[2].transform.position.z);
        }
        else if (dists[1] > dists[2])
        {
            height = Mathf.Max(dists[0], 20f);
            // direction = new Vector3(middle.x - dices[0].transform.position.x, 0, middle.z - dices[0].transform.position.z);
        }
        else
        {
            height = Mathf.Max(dists[0], 20f);
            //direction = new Vector3(middle.x - dices[1].transform.position.x, 0, middle.z - dices[1].transform.position.z);
        }
    }

}
