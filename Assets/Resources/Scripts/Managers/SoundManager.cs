using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{

    static SoundManager instance;
    public static SoundManager Instance
    {
        get
        {
            return instance;
        }
    }
    void Awake()
    {
        instance = this;
    }
    AudioSource source;


    public AudioClip browserCards;
    public AudioClip choseCard;
    public AudioClip diceShuffle;
    public AudioClip diceThrow;
    public AudioClip activateCard;
    public AudioClip[] wallImpact;
    public AudioClip[] objectImpact;
    public AudioClip[] destruction;
    public AudioClip[] peopleEcrased;
    public AudioClip s_conflagration;
    public AudioClip s_chuteMenhir;
    public AudioClip s_keepCalmBomb;
    public AudioClip s_dirtyOldOil;
    public AudioClip s_teaSpill;
    public AudioClip s_shadowOfCaneHill;
    public AudioClip s_vortex;
    public AudioClip s_jelly;
    public AudioClip s_eterminate;
    public AudioClip s_springHeeledJack;
    public AudioClip s_excalibur;
    public AudioClip s_hoodWink;
    public AudioClip s_royalAirForce;
	public AudioClip s_tornado;
	public AudioClip s_earthQuake;
    public AudioClip[] chaosAmbiance;


    public void PlayMonoSound( AudioClip ac, float vol)
    {
        GameObject go = new GameObject();
        AudioSource AS = go.AddComponent<AudioSource>();

        AS.clip = ac;
        AS.pitch = Random.Range(0.7f, 1.3f);
        AS.volume = vol;
        AS.loop = false;
        AS.Play();

        Destroy(go, ac.length + 1f);
    }


	public void PlayTabSound(GameObject target, AudioClip[] ac, float vol)
	{
        AudioClip currentAC = ac[Random.Range(0, ac.Length)];

        GameObject go = new GameObject();
        go.transform.position = target.transform.position;
        AudioSource AS = go.AddComponent<AudioSource>();

        AS.clip = currentAC;
        AS.pitch = Random.Range(0.7f, 1.3f);
        AS.volume = vol;
        AS.loop = false;
        AS.Play();

        Destroy(go, currentAC.length + 1f);
    }
}