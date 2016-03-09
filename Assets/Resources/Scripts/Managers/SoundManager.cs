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
    public AudioClip[] chaosAmbiance;


    public void PlaySound(GameObject target, AudioClip ac, float vol, bool changePitch)
    {
        if (!target.GetComponent<AudioSource>())
        {
            source = target.AddComponent<AudioSource>();
        }
        else
        {
            source = target.GetComponent<AudioSource>();
        }
        if (changePitch)
        {
            source.pitch = Random.Range(0.7f, 1.3f);
        }
        source.clip = ac;
        source.volume = vol;
        source.loop = false;
        source.Play();
    }
}