﻿using UnityEngine;
using System.Collections;
using System;
using DG.Tweening;

public class CameraScript : MonoBehaviour
{

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
    public float heightMin;
    float accuracy = Mathf.PI / 12;
	float force;
	Vector2 getForce;
	public float multiplierForce = 1f;


    private Vector3 endMarker;
    [HideInInspector]
    public float verticalTimeMove = 5;
    [HideInInspector]
    public float horizontalTimeMove = 4;
    private float startTime;
    private float journeyLength;
    private float height = 10;
    private Vector3 middle;
    Vector3 direction;
    private bool m_isShooting = false;
    public AnimationCurve sinus;
    private Tween tn;

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
        heightMin = 65;

        transform.localPosition = new Vector3(0, 58.939f, -140.5f);
        transform.localEulerAngles = new Vector3(28.233f, 0, 0);

        dices[0] = Instantiate(Resources.Load("GA/Prefabs/diceTest", typeof(GameObject))) as GameObject;
        dices[1] = Instantiate(Resources.Load("GA/Prefabs/diceTest", typeof(GameObject))) as GameObject;
        dices[2] = Instantiate(Resources.Load("GA/Prefabs/diceTest", typeof(GameObject))) as GameObject;
        for(int i = 0; i<3;i++)
        {
            dices[i].transform.parent = transform;
            dices[i].transform.localPosition = new Vector3(-6f + (6f * i), -5 + (((i + 1) % 2) * ((i + 1) % 2)), 20);
            dices[i].transform.rotation = UnityEngine.Random.rotation;
            TurnManager.instance.currentPlayer.GODices[i] = dices[i];
        }
        TurnManager.instance.rotateArrow(0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning(currentPosition);
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
        
        if (Input.GetButtonDown("ButtonA"))
        {
            SoundManager.Instance.PlayMonoSound(SoundManager.Instance.diceShuffle, 1f);
            StartCoroutine(ChargeTir());
        }
        if(!m_isShooting)
        {
            verticalMovment = Input.GetAxis("Vertical");
            if (verticalMovment > 0 && transform.eulerAngles.x < 6 || verticalMovment < 0 && transform.eulerAngles.x > 35)
            {

            }else
            transform.Rotate(new Vector3(-verticalMovment * speedRotationVerticalScope, 0, 0) * Time.deltaTime);

            horizontalMovment = Input.GetAxis("Horizontal");
            if (horizontalMovment != 0)
            {
                mapCenter.transform.Rotate(mapCenter.transform.up, -horizontalMovment * Time.deltaTime * speedRotationArround);
            }
        }
	}

    internal void cinematic()
    {
        currentPosition = POSITION.STATIC;
    }

    IEnumerator ChargeTir()
    {
        m_isShooting = true;
        while (!Input.GetButtonUp("ButtonA"))
        {
            checkforce();
            yield return null;
        }
        startTime = Time.time;
        SoundManager.Instance.PlayMonoSound(SoundManager.Instance.diceThrow, 1f);
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
        m_isShooting = false;
    }

	void GetPosition(GameObject[] farDices)
    { 
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
    }

    private float timer = 0;
    void checkforce()
    {

        force = sinus.Evaluate(timer);
        timer += Time.deltaTime/2;
        if(timer > 1)
        {
            timer = 0;
        }
        force *= 80;
        force = Mathf.Max(10f, force + 10);
        /*float hori = Input.GetAxis("LeftHorizontal");
        float verti = Input.GetAxis("LeftVertical");
        float dist = Vector2.Distance(getForce, new Vector2(hori, verti));
        force = Mathf.Min(force + dist*2, 90);
        line.a = 0.1f - 0.002f * (force - 10);
        getForce = new Vector2(hori, verti);
        if (dist < 0.1f)
        {
            force = Mathf.Max(0f, force - Time.deltaTime * 10);
        }*/
        TurnManager.instance.rotateArrow(force/100);
    }

    void follow()
    {
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
        if (tn != null || (tn != null && tn.IsPlaying()))
            return;
        Quaternion rotation = Quaternion.LookRotation(new Vector3(0, 58, -140) - transform.parent.position);
        transform.DORotate(new Vector3(28.233f,0,0) , 2f).SetEase(Ease.InOutSine);
        tn = transform.DOMove(new Vector3(0, 58, -140), 2f).SetEase(Ease.InOutSine).OnComplete(() =>
          {
              Debug.LogWarning("Finnish " + transform.position);
              transform.DOLocalMove(transform.localPosition, 0f).SetLoops(-1);
              transform.parent.DORotate(new Vector3(0, 180f, 0), 10f).SetRelative().SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
          });

        //reculer suivant distance entre les 2 dès les plus éloignés

    }



    void getMiddleOfThree()
    {
        middle = (dices[0].transform.position + dices[1].transform.position + dices[2].transform.position) / 3;
        endMarker = middle + Vector3.up * 1.3f * height;
        endMarker.y = Mathf.Max(heightMin, endMarker.y);
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
