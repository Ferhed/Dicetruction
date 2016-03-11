using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour
{

	Vector3 position;
	Rigidbody rb;
	Vector3 initialPosition;
    Player hittingPlayer = null;
    int score;
	// Use this for initialization
	void Awake ()
	{
        check();
        initialPosition = transform.position;
		rb = GetComponent<Rigidbody> ();
        if (rb.mass == 1) score = 75;
        else if (rb.mass == 2) score = 100;
        else if (rb.mass == 3) score = 125;
        else score = 150;
        rb.mass *= 100;
		//rb.Sleep();
	}

    void check()
    {
        if (!GetComponent<Collider>())
        {
            GameObject child = transform.GetChild(0).gameObject;
        }
    }

	void OnCollisionEnter (Collision collision)
	{
		if (name != "RDC") {
			if (this.gameObject.tag != "Props") {
				if (collision.gameObject.tag == "Ground")
                {
                    if (Vector3.Distance(transform.position, initialPosition) > 1)
                    {
                        destruct();
                    }
                }
			}
            else
            {
                if (collision.gameObject.tag == "Player" && (this.gameObject.name == "Bus" || this.gameObject.name == "Truck"))
                {
                    SoundManager.Instance.PlayMonoSound(SoundManager.Instance.s_conflagration, 1f);
                    FxManager.Instance.LaunchFX(FxManager.Instance.explosion, transform.position, Quaternion.identity);
                    Destroy(gameObject, 1f);
                }
            }
		}


		if (collision.relativeVelocity.magnitude > 5 && collision.gameObject.tag == "Player") {
            SoundManager.Instance.PlayTabSound(gameObject, SoundManager.Instance.wallImpact, 0.6f);
		}
	}

	public void bump ()
	{
        BuildManager.Instance.addElement(rb);
        hittingPlayer = TurnManager.instance.currentPlayer;
        initialPosition = transform.position;
	}

	public void changeWeight ()
	{
        if(tag != "Props")
		Invoke ("reallyChangeWeight", 1f);
	}

	void reallyChangeWeight ()
	{
		rb.mass -= 50f;
	}

	/*public IEnumerator checkStill ()
	{
		yield return new WaitForSeconds (0.5f);
		/* while (position != transform.position)
        {
            position = transform.position;
            yield return new WaitForSeconds(10f);
        }
		while (rb.velocity != Vector3.zero) {
			yield return new WaitForSeconds (1f);
		}
		if (name == "RDC" || this.gameObject.tag == "Props") {
			if (Vector3.Distance (transform.position, initialPosition) > 1) {
                destruct();
			}
		}
        //rb.isKinematic = true;
        // yield return null;
        BuildManager.Instance.delElement(gameObject);
    }*/


    void destruct ()
	{
        TurnManager.instance.currentPlayer.objectsDestroy++;
        if (hittingPlayer == null)
            hittingPlayer = TurnManager.instance.lastPlayer;
        if (tag == "Props")
        {
            if(hittingPlayer == TurnManager.instance.player1)
                TurnManager.instance.player1.addScore(true, score);
            else
                TurnManager.instance.player2.addScore(true, score);
        }
        else
        {
            if (hittingPlayer == TurnManager.instance.player1)
                TurnManager.instance.player1.addScore(false, score);
            else
                TurnManager.instance.player2.addScore(false, score);

        }
        Ui_Manager.Instance.MajScore();
        if (tag == "Props") { }
        else
        {
            SoundManager.Instance.PlayTabSound(gameObject, SoundManager.Instance.destruction, 0.4f);
            if (Random.Range(0, 100) < 5) SoundManager.Instance.PlayTabSound(gameObject, SoundManager.Instance.chaosAmbiance, 0.7f);
        }
        Invoke("reallyDestructNow", Random.Range(2f, 4f));
    }

    public void checkPosition()
    {
        if (Vector3.Distance(transform.position, initialPosition) > 1)
        {
            destruct();
        }
    }


    void reallyDestructNow()
    {
        Destroy(gameObject);
    }
}
