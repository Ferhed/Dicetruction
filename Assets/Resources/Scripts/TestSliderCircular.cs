using UnityEngine;
using System.Collections;

public class TestSliderCircular : MonoBehaviour
{
	public CircularSlider slider;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		float vertInput = Input.GetAxis ("Vertical");

		if (vertInput != 0) {
			slider.FillLevel += vertInput * Time.deltaTime * 2;
		}
	}
}
