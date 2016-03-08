﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

public enum UiElement
{
	RessourcesPanel = 0x01,
	YShowHand = 0x02,
	YShowDice = 0x03,
	XShowTacticView = 0x04,
	XShowBasicView = 0x05,
	PressBtnPanel = 0x06,
	PhaseTitle = 0x07,
	DraftCardPanel = 0x08,
	HandPlayer1 = 0x09,
	HandPlayer2 = 0x10,
	BToBack = 0x11,
}

public enum UiOptions
{
	Additive,
	Default,
	ForceHide,
}

public enum UiState
{
	Draft = UiElement.YShowHand | UiElement.PressBtnPanel | UiElement.DraftCardPanel,
	HandJ1 = UiElement.HandPlayer1 | UiElement.YShowHand | UiElement.PressBtnPanel,
	HandJ2 = UiElement.HandPlayer2 | UiElement.YShowHand | UiElement.PressBtnPanel,
	Positioning = UiElement.YShowHand | UiElement.XShowTacticView | UiElement.PressBtnPanel | UiElement.PhaseTitle,
	Tactical,
	Throw,
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
	private GameObject m_yShowHand;
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
    #endregion

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
		case UiState.Tactical:
			OnTactical ();
			break;
		case UiState.Throw:
			OnThrow ();
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
		//m_mainSlider.SetActive (false);
		m_phaseTitle.SetActive (false);
		m_pressBtnPanel.SetActive (false);
		m_ressourcesPanel.SetActive (false);
		m_selectCardPanel.SetActive (false);
		m_yShowDice.SetActive (false);
		m_yShowHand.SetActive (false);
		m_bToBack.SetActive (false);
	}

	private void OnDraftJ1 ()
	{
		hideAll ();
		if (TurnManager.GetInstance ().currentPlayer.getHandSize () > 0)
			m_yShowHand.SetActive (true);
		m_pressBtnPanel.SetActive (true);
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
		UpdateHand (m_handPlayer1, TurnManager.GetInstance ().player1, 0);
		m_yShowHand.SetActive (false);
		m_pressBtnPanel.SetActive (false);
		m_handPlayer1.SetActive (true);
		m_cardSelectedId = m_system.currentSelectedGameObject.transform.GetSiblingIndex ();
		m_system.SetSelectedGameObject (null);
	}

	private void OnHandJ2 ()
	{
		UpdateHand (m_handPlayer2, TurnManager.GetInstance ().player2, 1);
		m_yShowHand.SetActive (false);
		m_pressBtnPanel.SetActive (false);
		m_handPlayer2.SetActive (true);
		m_cardSelectedId = m_system.currentSelectedGameObject.transform.GetSiblingIndex ();
		m_system.SetSelectedGameObject (null);
	}

	private void OnPositioning ()
	{
		hideAll ();
		m_phaseTitle.SetActive (true);
		m_yShowHand.SetActive (true);
		m_pressBtnPanel.SetActive (true);

		Color alpha = m_phaseTitle.GetComponent<Image> ().color;
		alpha.a = 0;
		m_phaseTitle.GetComponent<Image> ().color = alpha;

		m_phaseTitle.GetComponent<Image> ().DOKill ();
		m_phaseTitle.GetComponent<Image> ().DOFade (1, 2).SetEase (Ease.OutSine).SetLoops (2, LoopType.Yoyo).OnComplete (() => {
			m_phaseTitle.SetActive (false);
		});
	}

	private void OnTactical ()
	{
		hideAll ();
		m_phaseTitle.SetActive (true);
		m_yShowHand.SetActive (true);
		m_pressBtnPanel.SetActive (true);

		Color alpha = m_phaseTitle.GetComponent<Image> ().color;
		alpha.a = 0;
		m_phaseTitle.GetComponent<Image> ().color = alpha;

		m_phaseTitle.GetComponent<Image> ().DOKill ();
		m_phaseTitle.GetComponent<Image> ().DOFade (1, 2).SetEase (Ease.OutSine).SetLoops (2, LoopType.Yoyo).OnComplete (() => {
			m_phaseTitle.SetActive (false);
		});
	}

	private void OnThrow ()
	{
		hideAll ();
		m_phaseTitle.SetActive (true);
		m_yShowHand.SetActive (true);
		m_pressBtnPanel.SetActive (true);
		m_bToBack.SetActive (true);

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
		m_yShowHand.SetActive (true);
		m_pressBtnPanel.SetActive (true);
		m_selectCardPanel.SetActive (true);

		List<Card> hand = TurnManager.GetInstance ().currentPlayer.GetHand ();
		for (int i = 0; i < 5; i++) {
			m_selectCardPanel.transform.GetChild (i).gameObject.SetActive (true);
			m_selectCardPanel.transform.GetChild (i).GetComponent<DraftCardUI> ().ActiveCard = hand [i];
			continue;
		}
		m_system.SetSelectedGameObject (m_selectCardPanel.transform.GetChild (0).gameObject);
	}

	private void OnDiceSelect ()
	{
		hideAll ();
		m_pressBtnPanel.SetActive (true);

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
		if (TurnManager.GetInstance ().currentPlayer.getHandSize () > 0) {
			m_yShowHand.SetActive (true);
		} else {
			m_yShowHand.SetActive (false);
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

	public bool SelectSpell ()
	{
		if (m_selectedSpell >= 3)
			return false;
		m_selectedSpell++;
		return true;
	}

	public void DeselectSpell ()
	{
		m_selectedSpell--;
	}
    
    public void MajScore()
    {
        int score = TurnManager.instance.player1.getScore();
        m_ScoreP1.text = score.ToString();
        score = TurnManager.instance.player2.getScore();
        m_ScoreP2.text = score.ToString();
    }
}


