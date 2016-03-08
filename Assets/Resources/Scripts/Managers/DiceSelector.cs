using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class DiceSelector : Singleton<DiceSelector>
{
	private Card m_spell;
	private GameObject[] m_dice;
	private GameObject m_selectedDie;


	private int m_selectedIndex = 0;
	private WaitForSpellAssignation m_callback;
	private List<int> m_indexList;

	[SerializeField]
	private Material BaseMaterial;
	[SerializeField]
	private Material SelectedMaterial;

	protected DiceSelector ()
	{
		
	}
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Reset ()
	{
		if (m_indexList == null)
			m_indexList = new List<int> ();
		else
			m_indexList.Clear ();
		m_indexList.Add (0);
		m_indexList.Add (1);
		m_indexList.Add (2);
	}

	public void Init (Card spell, GameObject[] Dice, WaitForSpellAssignation callback)
	{
		m_spell = spell;
		m_dice = Dice;
		m_selectedIndex = 0;
		m_callback = callback;
		m_dice [m_indexList [0]].GetComponent<MeshRenderer> ().material = SelectedMaterial;
		StartCoroutine (SelectDice ());
		/*if (spell.type == CardType.SingleDie)
			StartCoroutine (SelectDice ());
		else
			callback.NextSpell (-1);*/
	}

	IEnumerator SelectDice ()
	{
		Debug.Log ("Dice Selection");
		while (true) {
			int axis = (int)(Math.Sign (Input.GetAxis ("Horizontal")) * 1);
			int oldIndex = m_selectedIndex;
			m_selectedIndex = (m_selectedIndex + axis > m_indexList.Count - 1) ? 0 : ((m_selectedIndex + axis < 0) ? m_indexList.Count - 1 : m_selectedIndex + axis);


			if (oldIndex != m_selectedIndex) {
				m_dice [m_indexList [m_selectedIndex]].GetComponent<MeshRenderer> ().material = SelectedMaterial;
				m_dice [m_indexList [oldIndex]].GetComponent<MeshRenderer> ().material = BaseMaterial;
			}

			if (axis != 0)
				yield return new WaitForSeconds (0.2f);
			if (Input.GetButtonDown ("ButtonA"))
				break;
			yield return null;
		}
		yield return null;
		Debug.Log (m_indexList [m_selectedIndex]);
		int index = m_indexList [m_selectedIndex];
		m_dice [index].GetComponent<MeshRenderer> ().material.SetColor ("_OutlineColor", Color.red);
		m_indexList.RemoveAt (m_selectedIndex);
		m_callback.NextSpell (index);
		
	}
		
}
