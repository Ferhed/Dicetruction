using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;

public class CreditMenuHandler : MenuHandler
{
    [SerializeField]
    private GameObject m_canvas;

	// Use this for initialization
	void Start ()
	{
		base.Start ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		base.Update ();
	}

	public override void Appear ()
	{
        m_canvas.SetActive(true);
	}

	public override void Disappear ()
	{
        m_canvas.SetActive(false);
    }

	public override void ButtonDeselect (GameObject button)
	{
		
	}

	public override void ButtonSelect (GameObject button)
	{
		
	}
}
