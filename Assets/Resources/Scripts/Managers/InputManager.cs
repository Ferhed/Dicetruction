using UnityEngine;
using System.Collections;
using System;

public class InputManager : MonoBehaviour
{
	static InputManager instance;

	public Card cardPreSelected;
	public Dice dicePreSelected;

	public bool handActive;
	public bool inStartTurnPlayer;
	public bool inShootView;
	public bool diceSended;
	public bool inSelectSpell;
	public bool inSelectDice;
	public bool inCastSpell;
	public bool inDraft;

	void Awake ()
	{
		DontDestroyOnLoad (this);
		instance = this;

		//To UI
		handActive = false;
		inStartTurnPlayer = false;
		inShootView = false;
		diceSended = false;
		inSelectSpell = false;
		inSelectDice = false;
		inCastSpell = false;
		inDraft = false;

		//ToSelectDice&Card
		cardPreSelected = null;
		dicePreSelected = null;
	}

	public static InputManager GetInstance ()
	{
		if (instance == null) {
			instance = new InputManager ();
		}
		return instance;
	}

	public void OnPressButtonA ()
	{
		if (handActive) {
			return;
		}

		if (inStartTurnPlayer) {
			inStartTurnPlayer = false;
			inShootView = true;
			Ui_Manager.Instance.GoToState (UiState.Throw);
			return;
		}
		if (inSelectDice) {
			inSelectDice = false;
			inCastSpell = true;
			return;
		}
	}

	public void OnPressButtonB ()
	{
		if (handActive) {
			handActive = false;
			if (inStartTurnPlayer)
				Ui_Manager.Instance.GoToState (UiState.Positioning);
			else
				Ui_Manager.Instance.GoToState (UiState.Throw);
			return;
		}
		if (inShootView) {
			inShootView = false;
			inStartTurnPlayer = true;
			Ui_Manager.Instance.GoToState (UiState.Positioning);
			return;
		}
		if (inSelectDice) {
			inSelectDice = false;
			inSelectSpell = true;
			Ui_Manager.Instance.GoToState (UiState.SpellSelect);
		}
	}

	public void OnPressButtonX ()
	{
		if (handActive) {
			return;
		}
	}

	public void OnPressButtonY ()
	{
		if (handActive) {
			handActive = false;
			if (inStartTurnPlayer)
				Ui_Manager.Instance.GoToState (UiState.Positioning);
			else if (inShootView)
				Ui_Manager.Instance.GoToState (UiState.Throw);
			else if (inDraft)
				Ui_Manager.Instance.GoToState (UiState.Draft);
			return;
		}
		if (inStartTurnPlayer || inShootView || inDraft) {
			if (TurnManager.GetInstance ().currentPlayer == TurnManager.GetInstance ().player1 && TurnManager.GetInstance ().player1.getHandSize () > 0) {
				Ui_Manager.Instance.GoToState (UiState.HandJ1);
				handActive = true;
			}
			if (TurnManager.GetInstance ().player2.getHandSize () > 0 && TurnManager.GetInstance ().currentPlayer == TurnManager.GetInstance ().player2) {
				Ui_Manager.Instance.GoToState (UiState.HandJ2);
				handActive = true;
			}
		}
	}

	public void OnPressButtonLB ()
	{
		if (handActive) {
			return;
		}
		if (inShootView) {
			//ChangeAngle
		}
	}

	public void OnPressButtonRB ()
	{
		if (handActive) {
			return;
		}
		if (inShootView) {
			//ChangeAngle
		}
	}

	void Update ()
	{
		if (Input.GetButtonDown ("ButtonA")) {
			OnPressButtonA ();
		}
		if (Input.GetButtonDown ("ButtonB")) {
			OnPressButtonB ();
		}
		if (Input.GetButtonDown ("ButtonX")) {
			OnPressButtonX ();
		}
		if (Input.GetButtonDown ("ButtonY")) {
			OnPressButtonY ();
		}
		if (Input.GetButtonDown ("ButtonLB")) {
			OnPressButtonLB ();
		}
		if (Input.GetButtonDown ("ButtonRB")) {
			OnPressButtonRB ();
		}
	}
}
