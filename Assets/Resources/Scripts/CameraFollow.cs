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
	public GameObject middle;
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
		transform.position = Vector3.Lerp(startMarker.position, endMarker, fracJourney);
		transform.LookAt(middle.transform.position+direction/2);
	}

	void getMiddleOfThree()
	{
		middle.transform.position = (dices[0].transform.position + dices[1].transform.position+ dices[2].transform.position)/3;
		endMarker = middle.transform.position+Vector3.up*height+direction;
	}
	
	void SelectDices()
	{
		float[] dists = new float[3];
		dists[0] = Vector3.Distance(dices[0].transform.position, dices[1].transform.position);
		dists[1] = Vector3.Distance(dices[2].transform.position, dices[1].transform.position);
		dists[2] = Vector3.Distance(dices[2].transform.position, dices[0].transform.position);
		if (dists[0] > dists[1] && dists[0] > dists[2])
		{
			height = dists[0];
			direction = new Vector3(middle.transform.position.x-dices[2].transform.position.x,0,middle.transform.position.z-dices[2].transform.position.z);
		}
		else if (dists[1] > dists[2])
		{
			height = dists[1];
			direction = new Vector3(middle.transform.position.x-dices[0].transform.position.x,0,middle.transform.position.z-dices[0].transform.position.z);
		}
		else
		{
			height = dists[2];
			direction = new Vector3(middle.transform.position.x-dices[1].transform.position.x,0,middle.transform.position.z-dices[1].transform.position.z);
		}
	}

}
