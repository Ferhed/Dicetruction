using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class DraftCardUI : MonoBehaviour
{
	public Card ActiveCard {
		get {
			return m_activeCard;
		}
		set {
			m_activeCard = value;
			if (m_uiImage == null)
				m_uiImage = GetComponent<Image> ();
			if (value.Image != null)
				m_uiImage.sprite = value.Image;
		}
	}

	public bool IsSelected {
		get {
			return m_selected;
		}
	}

	[SerializeField]
	private Card m_activeCard;

	private Image m_uiImage;
	private bool m_selected = false;

	void Awake ()
	{
		m_uiImage = GetComponent<Image> ();
	}

	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{
	
	}

	public void OnSelect ()
	{
		transform.DOScale (1.2f, 0.2f).SetEase (Ease.InOutSine);
		GetComponent<Image> ().DOColor (new Color (0.75f, 0.75f, 0.75f, 1), 0.2f).SetEase (Ease.InOutSine);
	}

	public void OnDeselect ()
	{
		transform.DOScale (1, 0.2f).SetEase (Ease.InOutSine);
		GetComponent<Image> ().DOColor (Color.white, 0.2f).SetEase (Ease.InOutSine);
	}

	public void OnPressed ()
	{
		transform.DOMoveY ((m_selected) ? -25 : 25, 0.2f).SetRelative ().SetEase (Ease.InOutSine);
		m_selected = !m_selected;
	}
}
