using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Player : MonoBehaviour
{
	private int score;
	private int mana;
	private int multiplier;
    public int objectsDestroy = 0;
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

    public void addScore(bool isProps, int add)
    {
        score += add;
        if(objectsDestroy == 0)
        {

        }
        else if(objectsDestroy < 10)
        {
            if(isProps)
            {
                score += 10;
            }
            else
            {
                score += 20;
            }
        }
        else if (objectsDestroy < 20)
        {
            if (isProps)
            {
                score += 15;
            }
            else
            {
                score += 35;
            }
        }
        else if (objectsDestroy < 30)
        {
            if (isProps)
            {
                score += 25;
            }
            else
            {
                score += 55;
            }
        }
        else if (objectsDestroy < 40)
        {
            if (isProps)
            {
                score += 40;
            }
            else
            {
                score += 80;
            }
        }
        else if (objectsDestroy < 50)
        {
            if (isProps)
            {
                score += 60;
            }
            else
            {
                score += 110;
            }
        }
        else if (objectsDestroy < 75)
        {
            if (isProps)
            {
                score += 85;
            }
            else
            {
                score += 145;
            }
        }
        else if (objectsDestroy < 100)
        {
            if (isProps)
            {
                score += 115;
            }
            else
            {
                score += 185;
            }
        }
        else if (objectsDestroy < 150)
        {
            if (isProps)
            {
                score += 150;
            }
            else
            {
                score += 230;
            }
        }
        else if (objectsDestroy < 200)
        {
            if (isProps)
            {
                score += 190;
            }
            else
            {
                score += 280;
            }
        }
        else if (objectsDestroy < 250)
        {
            if (isProps)
            {
                score += 235;
            }
            else
            {
                score += 335;
            }
        }
        else
        {
            if (isProps)
            {
                score += 285;
            }
            else
            {
                score += 400;
            }
        }

        //changer UI score
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Card exc = new Excalibur(10, 0, 10, null);
            List<GameObject> targets = new List<GameObject>();
            targets.Add(GODices[0]);
            exc.Cast(targets);
        }
    }
}
