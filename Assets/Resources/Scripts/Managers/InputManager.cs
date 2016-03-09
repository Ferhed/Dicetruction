using UnityEngine;
using System.Collections;
using System;

public class InputManager : MonoBehaviour
{
	static InputManager instance;

	public Card cardPreSelected;
	public Dice dicePreSelected;
    public Ui_Manager UIInstance;
    public TurnManager TMInstance;

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
			if (inStartTurnPlayer) {
			}
            //Ui_Manager.Instance.GoToState (UiState.Positioning);
			else if (inDraft)
                UIInstance.GoToState (UiState.Draft);
			return;
		}
		/*if (inShootView) {
			inShootView = false;
			inStartTurnPlayer = true;
			Ui_Manager.Instance.GoToState (UiState.Positioning);
			return;
		}*/
		if (inSelectDice) {
			inSelectDice = false;
			inSelectSpell = true;
            UIInstance.GoToState (UiState.SpellSelect);
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
                UIInstance.GoToState (UiState.Positioning);
			else if (inDraft)
                UIInstance.GoToState (UiState.Draft);
			return;
		}
		if (inStartTurnPlayer || inShootView || inDraft) {
			if (TMInstance.currentPlayer == TMInstance.player1 && TMInstance.player1.getHandSize () > 0) {
                UIInstance.GoToState (UiState.HandJ1);
				handActive = true;
			}
			if (TMInstance.player2.getHandSize () > 0 && TMInstance.currentPlayer == TMInstance.player2) {
                UIInstance.GoToState (UiState.HandJ2);
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
