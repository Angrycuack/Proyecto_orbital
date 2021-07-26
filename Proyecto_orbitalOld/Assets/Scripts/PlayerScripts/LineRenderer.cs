using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderer : MonoBehaviour
{
    private LineRenderer lineRenderer;

    // animacion
    [SerializeField]
    private float animationDuration = 5f;

    
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        // probando de cara a la camara
        

        StartCoroutine(AnimateTheLine());

    }
    void Update()
    {
        
    }

    private IEnumerator AnimateTheLine()
    {
        float startTime = Time.time;

        

        yield return null;
    }
}
