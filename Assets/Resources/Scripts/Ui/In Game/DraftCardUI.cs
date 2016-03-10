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
			if (m_activeCard.GetEnergy () != 0) {
				m_costText.text = m_activeCard.GetEnergy ().ToString ();
				m_costText.gameObject.SetActive (true);
			} else
				m_costText.gameObject.SetActive (false);
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
	[SerializeField]
	private Text m_costText;

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
		GetComponent<Image> ().DOColor (Color.white, 0.2f).SetEase (Ease.InOutSine);
	}

	public void OnDeselect ()
	{
		transform.DOScale (1, 0.2f).SetEase (Ease.InOutSine);
		GetComponent<Image> ().DOColor (new Color (137f / 255f, 137f / 255f, 137f / 255f, 1), 0.2f).SetEase (Ease.InOutSine);
	}

	public void OnPressed ()
	{
		if (m_selected) {
			Ui_Manager.Instance.DeselectSpell (m_activeCard.GetEnergy ());
		} else if (!Ui_Manager.Instance.SelectSpell (m_activeCard.GetEnergy ())) {
			return;
		}
		transform.DOMoveY ((m_selected) ? -50 : 50, 0.2f).SetRelative ().SetEase (Ease.InOutSine);
		m_selected = !m_selected;
	}
}
