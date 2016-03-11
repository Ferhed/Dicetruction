using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using DG.Tweening;

public class Credit : MonoBehaviour {

    [SerializeField]
    [Multiline]
    private List<string> names;

    private Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        StartCoroutine(CreditUpdate());
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnEnable()
    {
        Debug.Log("caca");
        StartCoroutine(CreditUpdate());
    }

    void OnDisable()
    {
        text.DOKill(true);
        StopAllCoroutines();
    }

    IEnumerator CreditUpdate()
    {
        while (true)
        {
            for (int i = 0; i < names.Count; i++)
            {
                text.DOText(names[i], 2f).SetEase(Ease.InOutSine);
                yield return new WaitForSeconds(4f);
            }
            yield return null;
        }
    }
}
