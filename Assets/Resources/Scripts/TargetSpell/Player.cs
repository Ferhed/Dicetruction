using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Player : MonoBehaviour
{
	private int score;
	private int mana;
	private int multiplier;
    public int propsDestroy = 0;
	[HideInInspector]
	public GameObject[] GODices;
	public Dice[] dices;
	private List<Card> hand;

	void Start()
	{
		score = 0;
		mana = 0;
		multiplier = 1;
		GODices = new GameObject[3];
		dices = new Dice[3];
		hand = new List<Card> ();
	}

	public void AddMana (int value)
	{
		mana += value;
	}

	public int getScore ()
	{
		return score;
	}

    public int getMana()
    {
        return mana;
    }

    public void spendMana(int cost)
    {
        mana -= cost;
    }

	public void AddCardInHand (Card card)
	{
		hand.Add (card);
	}

	public void RemoveCardInHand (Card card)
	{
		hand.Remove (card);
	}

	public void EndOfTurn ()
	{
		multiplier = 1;
		mana = 0;
	}

	public int getHandSize ()
	{
		return hand.Count;
	}

	public List<Card> GetHand ()
	{
		return hand;
	}

	public void Cast (Card card, List<GameObject> targets)
	{
		card.Cast (targets);
		hand.Remove (card);
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Card exc = new Exterminate(10, 0, 10, null);
            List<GameObject> targets = new List<GameObject>();
            targets.Add(GODices[0]);
            targets.Add(GODices[1]);
            exc.Cast(targets);
        }
    }
}
