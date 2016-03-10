using UnityEngine;
using System.Collections;

public class TestLineRenderer : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    private bool finish;
    LineRenderer line;

    void Start ()
    {
        finish = true;
        line = gameObject.GetComponent<LineRenderer>();
        Debug.Log("Yolooo");
    }
	
	IEnumerator Line ()
    {
        
        yield return new WaitForEndOfFrame();

        line.SetVertexCount(105);
        line.SetWidth(0.1f, 0.1f);
        int index = 0;
        for (float i = 0; i < 210; i += 2)
        {
            line.SetPosition(index, new Vector3(3 , -(a * (i + b) * (i + b)) + c, i ));
            index++;
        }
        finish = true;
    }

    void Update()
    {
        if(finish)
        {
            StartCoroutine(Line());
            finish = false;
        }
    }
}
