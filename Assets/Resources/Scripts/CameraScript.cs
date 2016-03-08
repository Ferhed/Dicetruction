using UnityEngine;
using System.Collections;
using System;
using DG.Tweening;

public class CameraScript : MonoBehaviour
{
<<<<<<< HEAD

	float horizontalMovment;
	float verticalMovment;
	public GameObject mapCenter;
	public GameObject[] dices;
	public float speedRotationArround = 20f;
	public float speedRotationVerticalScope = 20f;
	public float speedRotationHorizontalScope = 20f;
	public float forceThrow = 200f;
	public float accuracyMin = Mathf.PI / 4;
	public float accuracyMax = Mathf.PI / 12;
	float accuracy = Mathf.PI / 12;
	float force;
	Vector2 getForce;
	public float multiplierForce = 1f;
=======
    float horizontalMovment;
    float verticalMovment;
    public GameObject mapCenter;
    public GameObject[] dices;
    public float speedRotationArround = 20f;
    public float speedRotationVerticalScope = 20f;
    public float speedRotationHorizontalScope = 20f;
    public float forceThrow = 200f;
    public float accuracyMin = Mathf.PI / 4;
    public float accuracyMax = Mathf.PI / 12;
    float accuracy = Mathf.PI / 12;
    float force;
    Vector2 getForce;
    public float multiplierForce = 1f;
>>>>>>> 5bdc0f383118a3c9e0c1a2612fc996e8452e5550

    
<<<<<<< HEAD
	private Vector3 endMarker;
	public float speed = 0.2F;
	private float startTime;
	private float journeyLength;
	private float height = 10;
	private Vector3 middle;
	Vector3 direction;



	enum POSITION
	{
		ROTATEARROUND,
		RAPIDDISPLACMENT,
		SCOPE,
		FOLLOW,
		STATIC,
	}

	POSITION currentPosition = POSITION.SCOPE;
	// Use this for initialization
	void Start ()
	{
		dices = new GameObject[3];

		dices [0] = Instantiate (Resources.Load ("GA/Prefabs/diceTest", typeof(GameObject))) as GameObject;
		dices [1] = Instantiate (Resources.Load ("GA/Prefabs/diceTest", typeof(GameObject))) as GameObject;
		dices [2] = Instantiate (Resources.Load ("GA/Prefabs/diceTest", typeof(GameObject))) as GameObject;
		for (int i = 0; i < 3; i++) {
			dices [i].transform.parent = transform;
			dices [i].transform.localPosition = new Vector3 (-2f + (2f * i), -3, 5.5f);
			dices [i].transform.rotation = UnityEngine.Random.rotation;
			TurnManager.instance.currentPlayer.GODices [i] = dices [i];
		}
	}

	// Update is called once per frame
	void Update ()
	{
		switch (currentPosition) {
		case POSITION.ROTATEARROUND:
			rotateArround ();
			break;
		case POSITION.RAPIDDISPLACMENT:
			rapidDisplacment ();
			break;
		case POSITION.SCOPE:
			scope ();
			break;
		case POSITION.FOLLOW:
			follow ();
			break;
		case POSITION.STATIC:
			staticCamera ();
			break;
		}

	}

	void rotateArround ()
	{
		if (Input.GetButtonDown ("ButtonX")) {
			currentPosition = POSITION.RAPIDDISPLACMENT;
		}
		if (Input.GetButtonDown ("ButtonA")) {
			goScope ();
		}

	}

	void rapidDisplacment ()
	{
		if (Input.GetButtonDown ("ButtonX")) {
			currentPosition = POSITION.ROTATEARROUND;
		}
		if (Input.GetButtonDown ("ButtonA")) {
			goScope ();
		}
	}

	void goScope ()
	{
		currentPosition = POSITION.SCOPE;
		//afficher cone par rapport a l'accuracy
	}

	void scope ()
	{
		/* if (Input.GetButtonDown("ButtonB"))
        {
            currentPosition = POSITION.ROTATEARROUND;
        }*/
		verticalMovment = Input.GetAxis ("Vertical");
		transform.Rotate (new Vector3 (-verticalMovment * speedRotationVerticalScope, 0, 0) * Time.deltaTime);

		horizontalMovment = Input.GetAxis ("Horizontal");
		if (horizontalMovment != 0) {
			mapCenter.transform.Rotate (mapCenter.transform.up, -horizontalMovment * Time.deltaTime * speedRotationArround);
		}

		if (Input.GetAxis ("Trigger") > 0.5f || Input.GetAxis ("Trigger") < -0.5f) {
			startTime = Time.time;
			foreach (GameObject currentDice in dices) {
				currentDice.transform.parent = null;
				force = Mathf.Max (force, 10f);
				Vector3 AF = transform.forward * force * 30 * multiplierForce;
				float magn = AF.magnitude;
				//magn *= Mathf.Tan(Random.Range(accuracy / 2, -accuracy / 2));
				magn *= Mathf.Tan (UnityEngine.Random.Range (accuracy / 2, -accuracy / 2));
				currentDice.GetComponent<Rigidbody> ().AddForce (AF + Vector3.right * magn / 8);
				currentDice.GetComponent<Rigidbody> ().useGravity = true;
				currentPosition = POSITION.FOLLOW;
				Dice DR = currentDice.GetComponent<Dice> ();
				StartCoroutine (DR.checkStill ());
				direction = transform.position - transform.parent.position;
				direction.Normalize ();
			}
=======
    private Vector3 endMarker;
    public float verticalTimeMove = 2;
    public float horizontalTimeMove = 1;
    private float startTime;
    private float journeyLength;
    private float height = 10;
    private Vector3 middle;
    Vector3 direction;



    enum POSITION
    {
        ROTATEARROUND,
        RAPIDDISPLACMENT,
        SCOPE,
        FOLLOW,
        STATIC,
    }

    POSITION currentPosition = POSITION.SCOPE;
    // Use this for initialization
    void Start()
    {
        dices = new GameObject[3];

        transform.localPosition = new Vector3(0, 58.939f, -140.5f);
        transform.eulerAngles = new Vector3(28.233f, 0, 0);

        dices[0] = Instantiate(Resources.Load("GA/Prefabs/diceTest", typeof(GameObject))) as GameObject;
        dices[1] = Instantiate(Resources.Load("GA/Prefabs/diceTest", typeof(GameObject))) as GameObject;
        dices[2] = Instantiate(Resources.Load("GA/Prefabs/diceTest", typeof(GameObject))) as GameObject;
        for(int i = 0; i<3;i++)
        {
            dices[i].transform.parent = transform;
            dices[i].transform.localPosition = new Vector3(-2f + (2f * i), -3 + (((i + 1) % 2) * ((i + 1) % 2)), 12);
            dices[i].transform.rotation = UnityEngine.Random.rotation;
            TurnManager.instance.currentPlayer.GODices[i] = dices[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentPosition)
        {
            case POSITION.ROTATEARROUND:
                rotateArround();
                break;
            case POSITION.RAPIDDISPLACMENT:
                rapidDisplacment();
                break;
            case POSITION.SCOPE:
                scope();
                break;
            case POSITION.FOLLOW:
                follow();
                break;
            case POSITION.STATIC:
                staticCamera();
                break;
        }

    }

    void rotateArround()
    {
        if (Input.GetButtonDown("ButtonX"))
        {
            currentPosition = POSITION.RAPIDDISPLACMENT;
        }
        if (Input.GetButtonDown("ButtonA"))
        {
            goScope();
        }

    }

    void rapidDisplacment()
    {
        if (Input.GetButtonDown("ButtonX"))
        {
            currentPosition = POSITION.ROTATEARROUND;
        }
        if (Input.GetButtonDown("ButtonA"))
        {
            goScope();
        }
    }

    void goScope()
    {
        currentPosition = POSITION.SCOPE;
        //afficher cone par rapport a l'accuracy
    }

    void scope()
    {
       /* if (Input.GetButtonDown("ButtonB"))
        {
            currentPosition = POSITION.ROTATEARROUND;
        }*/
        verticalMovment = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(-verticalMovment*speedRotationVerticalScope, 0, 0) * Time.deltaTime);
        
        horizontalMovment = Input.GetAxis("Horizontal");
        if (horizontalMovment != 0)
        {
            mapCenter.transform.Rotate(mapCenter.transform.up, -horizontalMovment * Time.deltaTime * speedRotationArround);
        }

        if (Input.GetAxis("Trigger") > 0.5f || Input.GetAxis("Trigger") < -0.5f)
        {
            startTime = Time.time;
            foreach (GameObject currentDice in dices)
            {
                currentDice.transform.parent = null;
                force = Mathf.Max(force, 10f);
                Vector3 AF = transform.forward * force * 30 * multiplierForce;
                float magn = AF.magnitude;
                //magn *= Mathf.Tan(Random.Range(accuracy / 2, -accuracy / 2));
                magn *= Mathf.Tan(UnityEngine.Random.Range(accuracy / 2, -accuracy / 2));
                currentDice.GetComponent<Rigidbody>().AddForce(AF + Vector3.right * magn / 8);
                currentDice.GetComponent<Rigidbody>().useGravity = true;
                currentPosition = POSITION.FOLLOW;
                Dice DR = currentDice.GetComponent<Dice>();
                StartCoroutine(DR.checkStill());
                direction = transform.position - transform.parent.position;
                direction.Normalize();
            }
>>>>>>> 5bdc0f383118a3c9e0c1a2612fc996e8452e5550
            
		}
		if (Input.GetButtonDown ("ButtonY")) {
			force = 0;
		}
		checkforce ();

		//charger le tir
	}

	public void changeAngle (int multiplier)
	{
		accuracy += multiplier * 5;
		accuracy = Mathf.Min (accuracyMin, accuracy);
		accuracy = Mathf.Max (accuracyMax, accuracy);
		Debug.Log (accuracy);
	}

	void checkforce ()
	{
		float hori = Input.GetAxis ("LeftHorizontal");
		float verti = Input.GetAxis ("LeftVertical");
		float dist = Vector2.Distance (getForce, new Vector2 (hori, verti));
		force = Mathf.Min (force + dist * 2, 100f);
		getForce = new Vector2 (hori, verti);
		if (dist < 0.1f) {
			force = Mathf.Max (0f, force - Time.deltaTime * 10);
		}
	}

	void follow ()
	{
		if (Input.GetButtonDown ("ButtonX")) {
			currentPosition = POSITION.STATIC;
		}
		SelectDices ();
		getMiddleOfThree ();
		journeyLength = Vector3.Distance (transform.position, endMarker);
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp (transform.position, endMarker, fracJourney);

		//transform.DOMove(endMarker, 12f);

		Vector3 dir = middle - transform.position;
		float Phi = Mathf.Acos (dir.y / dir.magnitude) * 180 / Mathf.PI;
		float Teta = Mathf.Atan2 (transform.position.z, transform.position.x) * 180 / Mathf.PI;
		transform.eulerAngles = new Vector3 (Phi - 90, -90 - Teta, 0);
	}

	void staticCamera ()
	{
		if (Input.GetButtonDown ("ButtonX")) {
			currentPosition = POSITION.FOLLOW;
		}

		//reculer suivant distance entre les 2 dès les plus éloignés

	}



	void getMiddleOfThree ()
	{
		middle = (dices [0].transform.position + dices [1].transform.position + dices [2].transform.position) / 3;
		endMarker = middle + Vector3.up * 1.3f * height;
	}

	void SelectDices ()
	{
		float[] dists = new float[3];
		dists [0] = Vector3.Distance (dices [0].transform.position, dices [1].transform.position);
		dists [1] = Vector3.Distance (dices [2].transform.position, dices [1].transform.position);
		dists [2] = Vector3.Distance (dices [2].transform.position, dices [0].transform.position);
		if (dists [0] > dists [1] && dists [0] > dists [2]) {
			height = Mathf.Max (dists [0], 20f);
			//direction = new Vector3(middle.x - dices[2].transform.position.x, 0, middle.z - dices[2].transform.position.z);
		} else if (dists [1] > dists [2]) {
			height = Mathf.Max (dists [1], 20f);
			// direction = new Vector3(middle.x - dices[0].transform.position.x, 0, middle.z - dices[0].transform.position.z);
		} else {
			height = Mathf.Max (dists [2], 20f);
			//direction = new Vector3(middle.x - dices[1].transform.position.x, 0, middle.z - dices[1].transform.position.z);
		}
	}

	/*void GetPosition(GameObject[] farDices)
=======
        }
        if (Input.GetButtonDown("ButtonY"))
        {
            force = 0;
        }
        checkforce();

        //charger le tir
    }

    public void changeAngle(int multiplier)
    {
        accuracy += multiplier*5;
        accuracy = Mathf.Min(accuracyMin, accuracy);
        accuracy = Mathf.Max(accuracyMax, accuracy);
        Debug.Log(accuracy);
    }

    void checkforce()
    {
        float hori = Input.GetAxis("LeftHorizontal");
        float verti = Input.GetAxis("LeftVertical");
        float dist = Vector2.Distance(getForce, new Vector2(hori, verti));
        force = Mathf.Min(force + dist*2, 100f);
        getForce = new Vector2(hori, verti);
        if (dist < 0.1f)
        {
            force = Mathf.Max(0f, force - Time.deltaTime * 10);
        }
    }

    void follow()
    {
        if (Input.GetButtonDown("ButtonX"))
        {
            currentPosition = POSITION.STATIC;
        }
        SelectDices();
        getMiddleOfThree();
        journeyLength = Vector3.Distance(transform.position, endMarker);
        transform.DOMoveY(endMarker.y, verticalTimeMove);
        transform.DOMoveX(endMarker.x, horizontalTimeMove);
        transform.DOMoveZ(endMarker.z, horizontalTimeMove);
        //transform.DOMove(endMarker, 12f);

        /** Look At */
        Vector3 dir = middle - transform.position;
        float Phi = Mathf.Acos(dir.y / dir.magnitude) * 180 / Mathf.PI;
        float Teta = Mathf.Atan2(transform.position.z, transform.position.x) * 180 / Mathf.PI;
        transform.DORotate(new Vector3(Phi-90,  -90 - Teta, 0), 2);
        /************/
    }

    void staticCamera()
    {
        if (Input.GetButtonDown("ButtonX"))
        {
            currentPosition = POSITION.FOLLOW;
        }

        //reculer suivant distance entre les 2 dès les plus éloignés

    }



    void getMiddleOfThree()
    {
        middle = (dices[0].transform.position + dices[1].transform.position + dices[2].transform.position) / 3;
        endMarker = middle + Vector3.up * 1.3f * height;
    }

    void SelectDices()
    {
        float[] dists = new float[3];
        dists[0] = Vector3.Distance(dices[0].transform.position, dices[1].transform.position);
        dists[1] = Vector3.Distance(dices[2].transform.position, dices[1].transform.position);
        dists[2] = Vector3.Distance(dices[2].transform.position, dices[0].transform.position);
        if (dists[0] > dists[1] && dists[0] > dists[2])
        {
            height = Mathf.Max(dists[0], 20f);
            //direction = new Vector3(middle.x - dices[2].transform.position.x, 0, middle.z - dices[2].transform.position.z);
        }
        else if (dists[1] > dists[2])
        {
            height = Mathf.Max(dists[1], 20f);
            // direction = new Vector3(middle.x - dices[0].transform.position.x, 0, middle.z - dices[0].transform.position.z);
        }
        else
        {
            height = Mathf.Max(dists[2], 20f);
            //direction = new Vector3(middle.x - dices[1].transform.position.x, 0, middle.z - dices[1].transform.position.z);
        }
    }

    /*void GetPosition(GameObject[] farDices)
>>>>>>> refs/remotes/origin/master
    {
        Vector3 center = (farDices[0].transform.position + farDices[1].transform.position) / 2;
        transform.position = new Vector3(center.x, transform.position.y, center.z);
        transform.LookAt(new Vector3(farDices[0].transform.position.x, transform.position.y, farDices[0].transform.position.z));
        transform.Rotate(0, 90, 0);
        transform.Translate(-transform.forward * Vector3.Distance(farDices[0].transform.position, farDices[1].transform.position));
       // transform.LookAt(getMiddleOfThree());
    }*/
}
