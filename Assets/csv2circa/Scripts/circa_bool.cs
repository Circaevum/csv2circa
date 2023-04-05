using UnityEngine;

public class circa_bool : MonoBehaviour
{
    LineRenderer lineRenderer;
    
    public void Plot(float[] time_angles, bool[] bools)
    {
        transform.position = transform.parent.position;
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = bools.Length;
        for (int i = 0; i < bools.Length; i++)
        {
            //print("Time Angle = " + time_angles[i]);
            float radius = 0.5f;
            if (bools[i] == true)
                radius = 1.2f;
            print("COS of " + (float)(i % 288) * (360 / 288) + " is " + Mathf.Cos((float)(i % 288) * (360 / 288) * Mathf.PI / 180));
            lineRenderer.SetPosition(i,
                    transform.position + new Vector3(
                        -radius * Mathf.Cos(((float)i % 288.0f) * (360.0f / 288.0f) * Mathf.PI / 180.0f - Mathf.PI / 2.0f),
                        radius * Mathf.Sin(((float)i % 288.0f) * (360.0f / 288.0f) * Mathf.PI / 180.0f - Mathf.PI / 2.0f),
                        (float)(1+i/288)/3.0f)
                    );
        }
    }
}
