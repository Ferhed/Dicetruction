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

	internal TurnManager TMInstance;
	internal Ui_Manager UIInstance;
	internal InputManager IPInstance;

	private bool turnPlayer1Ended;
	private bool turnPlayer2Ended;
	private bool globalTurnEnded;
	[HideInInspector]
	public bool cardSelected;

	public Player currentPlayer;
	
	public Camera globalCamera;
	[HideInInspector]
	public GameObject playerGameObject;
    public CircularSlider CS;
    public Player lastPlayer;



	void Awake ()
	{
		cardsInDraft = new List<Card> ();
		dicesValor = new List<int> ();

		instance = this;
		turnPlayer1Ended = false;
		turnPlayer2Ended = false;
		globalTurnEnded = false;
		cardSelected = false;

		StartCoroutine (StartGame ());
	}

	public static TurnManager GetInstance ()
	{
		if (instance == null) {
			instance = new TurnManager ();
		}
		return instance;
	}

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
        playerGameObject.transform.rotation = globalCamera.transform.parent.rotation;
        glo
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
		GameObject camera = playerGameObject.transform.GetChild (0).gameObject;
		//camera.GetComponent<CameraScript> ().enabled = false;
        SoundManager.Instance.PlayMonoSound(SoundManager.Instance.totalMana, 1f);
	}

	IEnumerator Turn ()
	{

		addCameraForPlayer ();
		UIInstance.GoToState (UiState.Positioning);
		IPInstance.inStartTurnPlayer = true;

		while (dicesValor.Count != 3) {
			yield return new WaitForEndOfFrame ();
		}
		valorOk ();


		//**********SELECT SPELL
		IPInstance.inShootView = false;
		IPInstance.inSelectSpell = true;
		IPInstance.inStartTurnPlayer = false;
		Debug.Log ("[State] : SelectSpell");
		UIInstance.GoToState (UiState.SpellSelect);
		UIInstance.ShowRessource (currentPlayer.getMana ());

		playerGameObject.transform.GetChild (0).GetChild (0).gameObject.SetActive (true);
		//Waiting until the player validate his choices
		yield return new WaitUntil (() => {
			return Input.GetButtonDown ("ButtonX");
		});
		List<Card> SelectedSpells = UIInstance.getSelectedSpell ();
		Debug.Log (SelectedSpells.Count);
        playerGameObject.transform.GetChild(0).GetComponent<CameraScript>().heightMin += 30;

        //Waiting until all the spells are assigned to a die

        yield return new WaitForSpellAssignation (SelectedSpells);
		playerGameObject.transform.GetChild (0).GetChild (0).gameObject.SetActive (false);
        playerGameObject.transform.GetChild(0).GetComponent<CameraScript>().cinematic();
        //Selection du Spell a lancer
        cardSelected = false;
        


		while (!BuildManager.Instance.buildingStatic) {
			yield return new WaitForSeconds (0.1f);
		}
		Debug.Log ("allStatic " + currentPlayer.name);
        
		currentPlayer.EndOfTurn ();
		killCamera ();

        if (currentPlayer == player1)
            turnPlayer1Ended = true;
        else
            turnPlayer2Ended = true;
        rotateArrow(0);
        EndOfTurn();
    }

	void killCamera ()
	{
		Debug.Log ("kill camera " + currentPlayer.name);
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
					targets.Add (player1.GODices [dieIndex]);
				} else {
					targets.Add (player2.GODices [dieIndex]);
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
			} else if ((card as Excalibur) != null) {
				if (currentPlayer == player1) {
					targets.Add (player1.GODices [dieIndex]);
				} else {
					targets.Add (player2.GODices [dieIndex]);
				}
			} else if ((card as Exterminate) != null) {
				if (currentPlayer == player1) {
					targets.Add (player1.GODices [dieIndex]);
				} else {
					targets.Add (player2.GODices [dieIndex]);
				}
            }
            else if ((card as Conflagration) != null)
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
            else if ((card as TeaSpill) != null)
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

            lastPlayer = currentPlayer;
            currentPlayer.Cast (card, targets);
			currentPlayer.RemoveCardInHand (card);
		}
	}

	IEnumerator GlobalTurn ()
	{
        /** Pour debug */
        //player1.AddCardInHand(new BombeH(0, 0, 0, CardManager.GetInstance().imageBombeH));
        //player1.AddCardInHand (new BombeH (0, 0, 0, CardManager.GetInstance ().imageBombeH));
        //player1.AddCardInHand (new BombeH (0, 0, 0, CardManager.GetInstance ().imageBombeH));
        /*******************/


        int nbCard = (5 - player1.getHandSize ()) + (5 - player2.getHandSize ());

		//SpawnCard a choisir
		if (player1.getScore () >= player2.getScore ()) {
			currentPlayer = player1;
		} else {
			currentPlayer = player2;
		}

		cardsInDraft.Clear ();
		for (int i = 0; i < nbCard; i++) {
			cardsInDraft.Add (CardManager.GetInstance ().GetRandomCard ());
			//cardsInDraft.Add (new BombeH (0, 0, 0, CardManager.GetInstance ().imageBombeH));
		}

        SoundManager.Instance.PlayMonoSound(SoundManager.Instance.pioche, 1f);
		UIInstance.setDraftCard (cardsInDraft);
		UIInstance.GoToState (UiState.Draft);
		IPInstance.inDraft = true;

		while (player1.getHandSize () < 5 || player2.getHandSize () < 5) {
			//we wait for the card to be selected
			yield return new WaitForCardSelected ();

			currentPlayer.AddCardInHand (IPInstance.cardPreSelected);

			if (currentPlayer == player1 && player2.getHandSize () < 5) {
				currentPlayer = player2;
				UIInstance.DraftTogglePlayer (2);
			} else if (player1.getHandSize () < 5) {
				currentPlayer = player1;
				UIInstance.DraftTogglePlayer (1);
			}

			//Debug.Log ("SizeHandP1 : " + player1.getHandSize ());
			//Debug.Log ("SizeHandP2 : " + player2.getHandSize ());
			yield return new WaitForEndOfFrame ();
		}


		globalTurnEnded = true;
		IPInstance.inDraft = false;
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


	public int getIndexPlayer ()
	{
		return (currentPlayer == player1) ? 1 : 2;
	}


    public void rotateArrow(float valor)
    {
        CS.FillLevel = valor;
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
        if(SpellToAssign.Count == 0)
        {
            allSpeelAssigned = true;
            return;
        }
		Debug.Log (TurnManager.GetInstance ().currentPlayer == TurnManager.GetInstance ().player1);
		Ui_Manager.Instance.GoToState (UiState.DiceSelect);
		m_speels = SpellToAssign;
		Debug.Log (SpellToAssign.Count);
		m_diceSelect = new List<int> ();
		m_index = 0;
		DiceSelector.Instance.Reset ();
		Ui_Manager.Instance.ShowCardSelected (m_speels [0]);
		DiceSelector.Instance.Init (m_speels [0], TurnManager.GetInstance ().currentPlayer.GODices, this);
	}

	public void NextSpell (int diceAssigned)
	{
		Ui_Manager.Instance.HidecardSelected ();
		m_diceSelect.Add (diceAssigned);
		m_index++;
		if (m_index != m_speels.Count) {
			Ui_Manager.Instance.ShowCardSelected (m_speels [m_index]);
			DiceSelector.Instance.Init (m_speels [m_index], TurnManager.GetInstance ().currentPlayer.GODices, this);
		} else {
			Debug.Log (m_speels.Count);
			for (int i = 0; i < m_speels.Count; i++) {
				Debug.Log (m_speels [i].ToString () + m_diceSelect [i].ToString ());
				TurnManager.GetInstance ().SelectCard (m_speels [i], m_diceSelect [i]);
			}
			allSpeelAssigned = true;
		}
	}
}
	
