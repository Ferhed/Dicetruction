using UnityEngine;
using System.Collections;

public class CircularSlider : MonoBehaviour
{

	public float FillLevel {
		get {
			return m_fill;
		}
		set {
			m_fill = Mathf.Clamp01 (value);
			updatePosition ();
		}
	}

	private float m_fill;
	private float m_degRot;
	private Transform m_centerOfRotation;

	void Awake ()
	{
		m_centerOfRotation = transform.GetChild (0);
		m_degRot = 0f;
	}
			
	// Update is called once per frame
	private void updatePosition ()
	{
		Debug.Log (m_fill);
		m_degRot = Mathf.Lerp (0, 360f, m_fill);
		m_centerOfRotation.rotation = Quaternion.Euler (0, 0, m_degRot);
	}
}
