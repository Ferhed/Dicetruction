using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum CardType
{
	SingleDie,
	AllDie,
	NoDie,
}

public abstract class Card
{
	public string name {
		get {
			return cardName;
		}
	}

	public CardType type {
		get {
			return m_type;
		}
	}

	protected string cardName;
	protected int energy;
	protected CardType m_type;

	public Sprite Image {
		get {
			return m_image;
		}
	}

	protected Sprite m_image;

	public Card (int energy, string name)
	{
		this.energy = energy;
		cardName = name;
	}

	public Card (int energy, string name, Sprite image)
	{
		this.energy = energy;
		this.m_image = image;
		cardName = name;
	}

	public string GetName ()
	{
		return cardName;
	}

	public int GetEnergy ()
	{
		return energy;
	}

	public abstract void Cast (List<GameObject> targets);

	public abstract Card Copy ();

}
