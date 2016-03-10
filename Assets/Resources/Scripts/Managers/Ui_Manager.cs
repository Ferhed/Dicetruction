using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

public enum UiOptions
{
	Additive,
	Default,
	ForceHide,
}

public enum UiState
{
	Draft,
	HandJ1,
	HandJ2,
	Positioning,
	SpellSelect,
	DiceSelect,
}

public class Ui_Manager : Singleton<Ui_Manager>
{
	private UiState m_state;

	public UiState State {
		get {
			return m_state;
		}
	}

	private EventSystem m_system;
	private TurnManager m_turnManager;
	private InputManager m_inputManager;
	private int m_cardSelectedId;
	private int m_selectedSpell;


	#region Panels

	[SerializeField]
	private GameObject m_mainSlider;
	[SerializeField]
	private GameObject m_ressourcesPanel;
	[SerializeField]
	private GameObject m_yShowHandJ1;
	[SerializeField]
	private GameObject m_yShowHandJ2;
	[SerializeField]
	private GameObject m_yShowDice;
	[SerializeField]
	private GameObject m_pressBtnPanel;
	[SerializeField]
	private GameObject m_phaseTitle;
	[SerializeField]
	private GameObject m_draftCardPanel;
	[SerializeField]
	private GameObject m_selectCardPanel;
	[SerializeField]
	private GameObject m_handPlayer1;
	[SerializeField]
	private GameObject m_handPlayer2;
	[SerializeField]
	private GameObject m_bToBack;
	[SerializeField]
	private Text m_ScoreP1;
	[SerializeField]
	private Text m_ScoreP2;
	[SerializeField]
	private Image m_cardSelected;
	[SerializeField]
	private GameObject m_xToValidate;

	#endregion

	private Text m_ressources;

	protected Ui_Manager ()
	{
		
	}

	// Use this for initialization
	void Start ()
	{
		m_mainSlider.SetActive (true);
		m_system = GameObject.FindObjectOfType<EventSystem> ();
		m_turnManager = TurnManager.GetInstance ();
		m_inputManager = InputManager.GetInstance ();
		m_ressources = m_ressourcesPanel.GetComponentInChildren<Text> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void GoToState (UiState state)
	{
		Debug.Log ("[UI Manager] go to state : " + state);
		m_state = state;
		switch (state) {
		case UiState.Draft:
			OnDraftJ1 ();
			break;
		case UiState.HandJ1:
			OnHandJ1 ();
			break;
		case UiState.HandJ2:
			OnHandJ2 ();
			break;
		case UiState.Positioning:
			OnPositioning ();
			break;
		case UiState.SpellSelect:
			OnSpellSelect ();
			break;
		case UiState.DiceSelect:
			OnDiceSelect ();
			break;
		default:
			break;
		}
	}

	#region State function

	private void hideAll ()
	{
		m_draftCardPanel.SetActive (false);
		m_handPlayer1.SetActive (false);
		m_handPlayer2.SetActive (false);
		m_phaseTitle.SetActive (false);
		m_pressBtnPanel.SetActive (false);
		m_ressourcesPanel.SetActive (false);
		m_selectCardPanel.SetActive (false);
		m_yShowDice.SetActive (false);
		m_yShowHandJ1.SetActive (false);
		m_bToBack.SetActive (false);
		m_xToValidate.SetActive (false);
	}

	private void OnDraftJ1 ()
	{
		hideAll ();
		if (m_turnManager.currentPlayer.getHandSize () > 0) {
			int player = m_turnManager.getIndexPlayer ();
			m_yShowHandJ1.SetActive (player == 1);
			m_yShowHandJ2.SetActive (player == 2);
		}
		m_pressBtnPanel.SetActive (true);
		m_pressBtnPanel.GetComponent<PressUi> ().Text = "To choose a card";
		m_draftCardPanel.SetActive (true);

		m_mainSlider.transform.FindChild ("J1 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredWidth = 100;
		m_mainSlider.transform.FindChild ("J1 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredHeight = 100;
		m_mainSlider.transform.FindChild ("J2 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredWidth = 70;
		m_mainSlider.transform.FindChild ("J2 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredHeight = 70;
		m_system.SetSelectedGameObject (m_draftCardPanel.transform.GetChild (m_cardSelectedId).gameObject);
	}

	public void SetDraftCardNumber (int number)
	{
		for (int i = number; i < m_draftCardPanel.transform.childCount; i++) {
			m_draftCardPanel.transform.GetChild (i).gameObject.SetActive (false);
		}
	}

	public void setDraftCard (List<Card> draftCards)
	{
		Debug.Log (draftCards.Count);
		for (int i = 0; i < 10; i++) {
			if (i < draftCards.Count) {
				m_draftCardPanel.transform.GetChild (i).gameObject.SetActive (true);
				m_draftCardPanel.transform.GetChild (i).GetComponent<DraftCardUI> ().ActiveCard = draftCards [i];
			} else {
				m_draftCardPanel.transform.GetChild (i).gameObject.SetActive (false);
			}
		}
		m_cardSelectedId = 0;
	}

	private void OnHandJ1 ()
	{
		UpdateHand (m_handPlayer1, m_turnManager.player1, 0);
		m_yShowHandJ1.SetActive (false);
		m_pressBtnPanel.SetActive (false);
		m_handPlayer1.SetActive (true);
		m_cardSelectedId = m_system.currentSelectedGameObject.transform.GetSiblingIndex ();
		m_system.SetSelectedGameObject (null);
	}

	private void OnHandJ2 ()
	{
		UpdateHand (m_handPlayer2, m_turnManager.player2, 1);
		m_yShowHandJ1.SetActive (false);
		m_pressBtnPanel.SetActive (false);
		m_handPlayer2.SetActive (true);
		m_cardSelectedId = m_system.currentSelectedGameObject.transform.GetSiblingIndex ();
		m_system.SetSelectedGameObject (null);
	}

	private void OnPositioning ()
	{
		int player = m_turnManager.getIndexPlayer ();
		hideAll ();
		m_yShowHandJ1.SetActive (player == 1);
		m_yShowHandJ2.SetActive (player == 2);

		m_mainSlider.transform.FindChild ("J1 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredWidth = (player == 2) ? 70 : 100;
		m_mainSlider.transform.FindChild ("J1 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredHeight = (player == 2) ? 70 : 100;
		m_mainSlider.transform.FindChild ("J2 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredWidth = (player == 1) ? 70 : 100;
		m_mainSlider.transform.FindChild ("J2 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredHeight = (player == 1) ? 70 : 100;

		m_phaseTitle.SetActive (true);
		m_yShowHandJ1.SetActive (true);
		//m_pressBtnPanel.SetActive (true);

		Color alpha = m_phaseTitle.GetComponent<Image> ().color;
		alpha.a = 0;
		m_phaseTitle.GetComponent<Image> ().color = alpha;

		m_phaseTitle.GetComponent<Image> ().DOKill ();
		m_phaseTitle.GetComponent<Image> ().DOFade (1, 2).SetEase (Ease.OutSine).SetLoops (2, LoopType.Yoyo).OnComplete (() => {
			m_phaseTitle.SetActive (false);
		});
	}

	private void OnSpellSelect ()
	{
		hideAll ();
		m_phaseTitle.SetActive (true);
		m_yShowHandJ1.SetActive (true);
		m_pressBtnPanel.SetActive (true);
		m_selectCardPanel.SetActive (true);
		m_yShowHandJ1.SetActive (false);
		m_yShowHandJ2.SetActive (false);
		m_xToValidate.SetActive (true);

		List<Card> hand = m_turnManager.currentPlayer.GetHand ();
		for (int i = 0; i < hand.Count; i++) {
			m_selectCardPanel.transform.GetChild (i).gameObject.SetActive (true);
			m_selectCardPanel.transform.GetChild (i).GetComponent<DraftCardUI> ().ActiveCard = hand [i];
		}
		m_system.SetSelectedGameObject (m_selectCardPanel.transform.GetChild (0).gameObject);
	}

	private void OnDiceSelect ()
	{
		hideAll ();
		m_pressBtnPanel.SetActive (true);
		m_pressBtnPanel.GetComponent<PressUi> ().Text = "To choose a dice";

	}

	#endregion

	public void DraftCardSelect (DraftCardUI cardToAdd)
	{
		m_inputManager.cardPreSelected = cardToAdd.ActiveCard;
		cardToAdd.OnDeselect ();
		WaitForCardSelected.cardSelected = true;

		cardToAdd.gameObject.SetActive (false);
		cardToAdd.transform.SetAsLastSibling ();
		m_system.SetSelectedGameObject (m_draftCardPanel.transform.GetChild (0).gameObject);
	}

	public void DraftTogglePlayer (int player)
	{
		m_yShowHandJ1.SetActive (false);
		m_yShowHandJ2.SetActive (false);
		GameObject showHand = (m_turnManager.currentPlayer == m_turnManager.player1) ? m_yShowHandJ1 : m_yShowHandJ2;

		if (m_turnManager.currentPlayer.getHandSize () > 0) {
			showHand.SetActive (true);
		} else {
			showHand.SetActive (false);
		}
		m_mainSlider.transform.FindChild ("J1 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredWidth = (player == 2) ? 70 : 100;
		m_mainSlider.transform.FindChild ("J1 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredHeight = (player == 2) ? 70 : 100;
		m_mainSlider.transform.FindChild ("J2 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredWidth = (player == 1) ? 70 : 100;
		m_mainSlider.transform.FindChild ("J2 Panel").FindChild ("Panel").GetComponent<LayoutElement> ().preferredHeight = (player == 1) ? 70 : 100;
	}

	private void UpdateHand (GameObject Hand, Player owner, int idPlayer)
	{
		Transform hand = Hand.transform.FindChild ("Panel");
		List<Card> Cards = owner.GetHand ();
		Debug.Log (Cards.Count);

		for (int i = idPlayer; i < 5 + idPlayer; i++) {
			if (i < Cards.Count + idPlayer) {
				hand.GetChild (i).gameObject.SetActive (true);
				hand.GetChild (i).gameObject.GetComponent<DraftCardUI> ().ActiveCard = Cards [i - idPlayer];
			} else
				hand.GetChild (i).gameObject.SetActive (false);
		}
	}

	public List<Card> getSelectedSpell ()
	{
		List<Card> selectedSpells = new List<Card> ();
		for (int i = 0; i < m_selectCardPanel.transform.childCount; i++) {
			if (m_selectCardPanel.transform.GetChild (i).GetComponent<DraftCardUI> ().IsSelected) {
				selectedSpells.Add (m_selectCardPanel.transform.GetChild (i).GetComponent<DraftCardUI> ().ActiveCard);
				m_selectCardPanel.transform.GetChild (i).GetComponent<DraftCardUI> ().OnPressed ();
				m_selectCardPanel.transform.GetChild (i).GetComponent<DraftCardUI> ().OnDeselect ();
			}
		}
		return selectedSpells;
	}

	public bool SelectSpell (DraftCardUI card)
	{
		int ressource = int.Parse (m_ressources.text);
		if (card.ActiveCard.GetEnergy () == 0) {
			m_turnManager.SelectCard (card.ActiveCard, 0);
			card.gameObject.SetActive (false);
			card.gameObject.transform.SetAsLastSibling ();
			m_system.SetSelectedGameObject (card.gameObject.transform.parent.GetChild (0).gameObject);
			return false;
		}
		ressource -= card.ActiveCard.GetEnergy ();
		if (m_selectedSpell >= 3 || ressource < 0)
			return false;
		m_selectedSpell++;
		m_ressources.text = ressource.ToString ();
		return true;
	}

	public void DeselectSpell (int cost)
	{
		m_selectedSpell--;
		m_ressources.text = (int.Parse (m_ressources.text) + cost).ToString ();
	}

	public void MajScore ()
	{
		int score = m_turnManager.player1.getScore ();
		m_ScoreP1.text = score.ToString ();
		score = m_turnManager.player2.getScore ();
		m_ScoreP2.text = score.ToString ();
	}

	public void ShowCardSelected (Card spell)
	{
		m_cardSelected.gameObject.SetActive (true);
		m_cardSelected.sprite = spell.Image;
	}

	public void HidecardSelected ()
	{
		m_cardSelected.gameObject.SetActive (false);
	}

	public void ShowRessource (int ressource)
	{
		m_ressourcesPanel.SetActive (true);
		m_ressourcesPanel.GetComponentInChildren<Text> ().text = ressource.ToString ();
	}
}


