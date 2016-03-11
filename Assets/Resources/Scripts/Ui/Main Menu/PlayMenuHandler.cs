using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayMenuHandler : MenuHandler
{

	// Use this for initialization
	void Start ()
	{
		base.Start ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		base.Update ();
	}

    public void PlayGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
