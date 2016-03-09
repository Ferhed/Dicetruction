using UnityEngine;
using System.Collections;

public class TestLineRenderer : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    private bool finish;

	void Start ()
    {
        finish = true;
	}
	
	IEnumerator Line ()
    {
        
        yield return new WaitForSeconds(0.1f);

        LineRenderer line = gameObject.GetComponent<LineRenderer>();
        line.SetVertexCount(105);
        line.SetWidth(0.1f, 0.1f);
        int index = 0;
        for (float i = 0; i < 210; i += 2)
        {
            line.SetPosition(index, new Vector3(3 , -(a * (i + b) * a * (i + b)) + c, i+5));
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
