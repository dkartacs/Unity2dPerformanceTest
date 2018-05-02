using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

    public LineRenderer lineRenderer;

    public void Draw(Vector3[] points)
    {
        lineRenderer.SetPositions(points);
    }

}
