using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class TurnManager : MonoBehaviour
{
	public static TurnManager instance;

	[HideInInspector]
	public Player player1;
	[HideInInspector]
	public Player player2;

	private List<Card> cardsInDraft;
	private List<int> dicesValor;
	//
	private bool turnPlayer1Ended;
	private bool turnPlayer2Ended;
	private bool globalTurnEnded;
	[HideInInspector]
	public bool cardSelected;
	//
	[HideInInspector]
	public Player currentPlayer;
	//
	public Camera globalCamera;
	[HideInInspector]
	public GameObject playerGameObject;

	void Awake ()
	{
		cardsInDraft = new List<Card> ();
		dicesValor = new List<int> ();
		//
		instance = this;
		turnPlayer1Ended = false;
		turnPlayer2Ended = false;
		globalTurnEnded = false;
		cardSelected = false;

		StartCoroutine (StartGame ());
	}
	//
	public static TurnManager GetInstance ()
	{
		if (instance == null) {
			instance = new TurnManager ();
		}
		return instance;
	}
	//
	public List<Card> getHandCurrentPlayer ()
	{
		return currentPlayer.GetHand ();
	}

	public void EndOfTurn ()
	{
		if (currentPlayer == player1) {
			currentPlayer = player2;
		} else {
			currentPlayer = player1;
		}
	}

	IEnumerator StartGame ()
	{
		yield return new WaitForSeconds (0.2f);

		currentPlayer = player1;
		StartCoroutine (Game ());
	}

	public IEnumerator Game ()
	{
		yield return new WaitForEndOfFrame ();
		StartCoroutine (GlobalTurn ());

		while (!globalTurnEnded)
			yield return new WaitForEndOfFrame ();
		Debug.Log ("TurnP1");
		currentPlayer = player1;
		StartCoroutine (Turn ());

		while (!turnPlayer1Ended)
			yield return new WaitForEndOfFrame ();

		//Tour du joueur 2
		Debug.Log ("TurnP2");
		StartCoroutine (Turn ());

		while (!turnPlayer2Ended)
			yield return new WaitForEndOfFrame ();
	}

	void addCameraForPlayer ()
	{
		playerGameObject = Instantiate (Resources.Load ("GA/Prefabs/MapCenter", typeof(GameObject))) as GameObject;
		playerGameObject.transform.position = Vector3.zero;
		globalCamera.enabled = false;
	}

	public void addValor (int valor)
	{
		dicesValor.Add (valor);
	}

	void valorOk ()
	{
		int valor = dicesValor [0] + dicesValor [1] + dicesValor [2];
		dicesValor.Clear ();
		currentPlayer.AddMana (valor);
		Debug.Log (valor);
		GameObject camera = playerGameObject.transform.GetChild (0).gameObject;
		camera.GetComponent<CameraScript> ().enabled = false;
	}

	IEnumerator Turn ()
	{
		addCameraForPlayer ();
		Ui_Manager.Instance.GoToState (UiState.Throw);
		InputManager.GetInstance ().inStartTurnPlayer = true;

		while (dicesValor.Count != 3) {
			yield return new WaitForEndOfFrame ();
		}
		valorOk ();

		//**********SELECT SPELL
		InputManager.GetInstance ().inShootView = false;
		InputManager.GetInstance ().inSelectSpell = true;
		Debug.Log ("[State] : SelectSpell");
		Ui_Manager.Instance.GoToState (UiState.SpellSelect);

		//Waiting until the player validate his choices
		yield return new WaitUntil (() => {
			return Input.GetButtonDown ("ButtonX");
		});
		List<Card> SelectedSpells = Ui_Manager.Instance.getSelectedSpell ();
		Debug.Log (SelectedSpells.Count);

		//Waiting until all the spells are assigned to a die

		yield return new WaitForSpellAssignation (SelectedSpells);
		//Selection du Spell a lancer
		cardSelected = false;
		if (currentPlayer == player1)
			turnPlayer1Ended = true;
		else
			turnPlayer2Ended = true;
		currentPlayer.EndOfTurn ();

		killCamera ();

		EndOfTurn ();
	}

	void killCamera ()
	{
		foreach (GameObject dice in currentPlayer.GODices) {
			Destroy (dice);
		}
		globalCamera.enabled = true;
		Destroy (playerGameObject);
	}


	public void SelectCard (Card card, int dieIndex)
	{
		cardSelected = true;
		Debug.Log (player1.GODices [dieIndex]);
		//Cast un Spell
		if (!turnPlayer2Ended) {
			List<GameObject> targets = new List<GameObject> ();

			if ((card as Vortex) != null) {
				if (currentPlayer == player1) {
					targets.Add (player1.dices [dieIndex].gameObject);
				} else {
					targets.Add (player2.dices [dieIndex].gameObject);
				}
			} else if ((card as Seisme) != null) {
				StartCoroutine ((card as Seisme).yollohSeisme ());
			} else if ((card as Tilt) != null) {
				if (currentPlayer == player1) {
					targets.Add (player1.GODices [0]);
					targets.Add (player1.GODices [1]);
					targets.Add (player1.GODices [2]);
				} else {
					targets.Add (player2.GODices [0]);
					targets.Add (player2.GODices [1]);
					targets.Add (player2.GODices [2]);
				}
			} else if ((card as JamesBond) != null) {
				if (currentPlayer == player1) {
					targets.Add (player1.gameObject);
					targets.Add (player2.gameObject);
				} else {
					targets.Add (player2.gameObject);
					targets.Add (player1.gameObject);
				}
			} else if ((card as BombeH) != null) {
				if (currentPlayer == player1) {
					targets.Add (player1.GODices [dieIndex]);
				} else {
					targets.Add (player2.GODices [dieIndex]);
				}
			}
            else if ((card as Excalibur) != null)
            {
                if (currentPlayer == player1)
                {
                    targets.Add(player1.GODices[dieIndex]);
                }
                else
                {
                    targets.Add(player2.GODices[dieIndex]);
                }
            }

            currentPlayer.Cast (card, targets);
			currentPlayer.RemoveCardInHand (card);
		}
	}

	IEnumerator GlobalTurn ()
	{
        /** Pour debug */
        player1.AddCardInHand(new BombeH(0, 0, 0, CardManager.GetInstance().imageBombeH));
        player1.AddCardInHand (new BombeH (0, 0, 0, CardManager.GetInstance ().imageBombeH));
		player1.AddCardInHand (new BombeH (0, 0, 0, CardManager.GetInstance ().imageBombeH));
        /*******************/



		int nbCard = (5 - player1.getHandSize ()) + (5 - player2.getHandSize ());

		//SpawnCard a choisir
		if (player2.getScore () < player1.getScore ()) {
			currentPlayer = player2;
		}
        
		for (int i = 0; i < nbCard; i++)
        {
            //cardsInDraft.Add(CardManager.GetInstance().GetRandomCard());
            cardsInDraft.Add(new BombeH(0, 0, 0, CardManager.GetInstance().imageBombeH));
        }

		Ui_Manager.Instance.setDraftCard (cardsInDraft);
		Ui_Manager.Instance.GoToState (UiState.Draft);
		InputManager.GetInstance ().inDraft = true;

		while (player1.getHandSize () < 5 || player2.getHandSize () < 5) {
			//we wait for the card to be selected
			yield return new WaitForCardSelected ();

			currentPlayer.AddCardInHand (InputManager.GetInstance ().cardPreSelected);

			if (currentPlayer == player1 && player2.getHandSize () < 5) {
				currentPlayer = player2;
				Ui_Manager.Instance.DraftTogglePlayer (2);
			} else if (player1.getHandSize () < 5) {
				currentPlayer = player1;
				Ui_Manager.Instance.DraftTogglePlayer (1);
			}

			//Debug.Log ("SizeHandP1 : " + player1.getHandSize ());
			//Debug.Log ("SizeHandP2 : " + player2.getHandSize ());
			yield return new WaitForEndOfFrame ();
		}


		globalTurnEnded = true;
		InputManager.GetInstance ().inDraft = false;
		yield return null;
	}

	void Update ()
	{
		if (turnPlayer2Ended) {
			globalTurnEnded = false;
			turnPlayer1Ended = false;
			turnPlayer2Ended = false;
			StartCoroutine (Game ());
		}
	}
}

class WaitForCardSelected : CustomYieldInstruction
{
	static public bool cardSelected = false;

	public override bool keepWaiting {
		get {
			if (cardSelected) {
				cardSelected = false;
				return false;
			}
			return true;
		}
	}

	public WaitForCardSelected ()
	{
		
	}
}

public class WaitForSpellAssignation : CustomYieldInstruction
{
	private bool allSpeelAssigned = false;
	private List<Card> m_speels;
	private List<int> m_diceSelect;
	private int m_index;

	public override bool keepWaiting {
		get {
			return !allSpeelAssigned;
		}
	}

	public WaitForSpellAssignation (List<Card> SpellToAssign)
	{
		Debug.Log (TurnManager.GetInstance ().currentPlayer == TurnManager.GetInstance ().player1);
		Ui_Manager.Instance.GoToState (UiState.DiceSelect);
		m_speels = SpellToAssign;
		m_diceSelect = new List<int> ();
		m_index = 0;
		DiceSelector.Instance.Reset ();
		DiceSelector.Instance.Init (m_speels [0], TurnManager.GetInstance ().currentPlayer.GODices, this);
	}

	public void NextSpell (int diceAssigned)
	{
		m_diceSelect.Add (diceAssigned);
		m_index++;
		if (m_index != m_speels.Count)
			DiceSelector.Instance.Init (m_speels [m_index], TurnManager.GetInstance ().currentPlayer.GODices, this);
		else {
			Debug.Log (m_speels.Count);
			for (int i = 0; i < m_speels.Count; i++) {
				Debug.Log (m_speels [i].ToString () + m_diceSelect [i].ToString ());
				TurnManager.GetInstance ().SelectCard (m_speels [i], m_diceSelect [i]);
			}
			allSpeelAssigned = true;
		}
	}
}
	
