using UnityEngine;
using System.Collections;

public class stopParticle : MonoBehaviour {


    ParticleSystem ps;
	// Use this for initialization
	void Start () {
        ps = GetComponent<ParticleSystem>();
        Invoke("stopLol", 0.1f);
	}

    void stopLol()
    {
        ps.Pause();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
