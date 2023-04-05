using System;
using System.Linq;
using UnityEngine;

public class circa_int : MonoBehaviour
{
    LineRenderer lineRenderer;

    public void Plot(int[] integers)
    {
        transform.position = transform.parent.position;
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = integers.Length;
        float min = (float)integers.Min();
        float max = (float)integers.Max();
        for (int i = 0; i < integers.Length; i++)
        {
            float radius = 0.74f+((float)integers[i]-min)/(max-min)/4;
            lineRenderer.SetPosition(i,
                    transform.position + new Vector3(
                        -radius * Mathf.Cos(((float)i % 288.0f) * (360.0f / 288.0f) * Mathf.PI / 180.0f - Mathf.PI / 2.0f),
                        radius * Mathf.Sin(((float)i % 288.0f) * (360.0f / 288.0f) * Mathf.PI / 180.0f - Mathf.PI / 2.0f),
                        (float)(1 + i / 288) / 3.0f)
                    );
        }
    }
}
