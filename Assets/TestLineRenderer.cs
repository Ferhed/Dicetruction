using UnityEngine;
using System.Collections;

public class TestLineRenderer : MonoBehaviour
{
    public float a;
    public float b;
    public float c;

	void Start ()
    {
        
	}
	
	void Update ()
    {
        LineRenderer line = gameObject.GetComponent<LineRenderer>();
        line.SetVertexCount(30000);
        line.SetWidth(0.1f, 0.1f);
        int index = 0;
        for (float i = 0; i < 3000; i += 0.1f)
        {
            line.SetPosition(index, new Vector3(0, -(a * (i + b) * a * (i + b)) + c, i));

            index++;
        }
    }
}
