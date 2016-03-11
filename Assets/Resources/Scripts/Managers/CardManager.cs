using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardManager : MonoBehaviour
{
	private static CardManager instance;

	private List<Card> allCards;

	[Header ("Pour les GD, Faites vous plaiz !")]
	public float BombeHRadius;
	public int BombeHEnergyCoast;
	public float BombeHForceExplosion;
	public int TiltEnergyCoast;
	public int TiltForce;
	public float VortexRadius;
	public int VortexEnergyCoast;
	public float VortexForceExplosion;
	public int SeismeEnergyCoast;
	public float SeismeForceExplosion;
	public float ExcaliburRadius;
	public int ExcaliburEnergyCoast;
	public float ExcaliburForceExplosion;
	public float ExterminateRadius;
	public int ExterminateEnergyCoast;
	public float ExterminateForceExplosion;
    public float ConflagrationPuissance;
    public int ConflagrationCost;
    public float TeaPuissance;
    public int TeaCost;
    [Header("Touchez plus a rien ! En dessous c'est pas pour vous")]


    public Sprite imageBombeH;
    public Sprite imageVortex;
    public Sprite imageTilt;
    public Sprite imageSeime;
    public Sprite imageExcalibur;
    public Sprite imageExterminate;
    public Sprite imageConflagration;
    public Sprite imageTea;

    void Awake ()
	{   
		instance = this;
		allCards = new List<Card> ();
		InitialyzeCards ();
	}

	public Card GetRandomCard ()
	{
		int rand = UnityEngine.Random.Range (0, allCards.Count);
		Card copy = allCards[rand].Copy ();
		return copy;
	}

	private void InitialyzeCards ()
	{
		allCards.Add (new BombeH (BombeHRadius, BombeHEnergyCoast, BombeHForceExplosion, imageBombeH));
		allCards.Add (new Tilt (TiltEnergyCoast, TiltForce, imageTilt));
		allCards.Add (new Vortex (VortexRadius, VortexEnergyCoast, VortexForceExplosion, imageVortex));
		allCards.Add (new Seisme (SeismeEnergyCoast, SeismeForceExplosion, imageSeime));
		allCards.Add (new Excalibur (ExcaliburRadius, ExcaliburEnergyCoast, ExcaliburForceExplosion, imageExcalibur));
		allCards.Add (new Exterminate (ExterminateRadius, ExterminateEnergyCoast, ExterminateForceExplosion, imageExterminate));
        allCards.Add(new Conflagration(1, ConflagrationCost, ConflagrationPuissance, imageConflagration));
        allCards.Add(new TeaSpill(1, TeaCost, TeaPuissance, imageTea));
	}

	public static CardManager GetInstance ()
	{
		return instance;
	}
}
