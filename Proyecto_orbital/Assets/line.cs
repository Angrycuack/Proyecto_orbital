using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    LineRenderer lineRenderer;

    [SerializeField]
    public GameObject centralSphere;
    [SerializeField]
    public GameObject orbit;

    private Vector3 csPosition;
    private Vector3 orbitPosition;
    void Start()
    {
        lineRenderer = this.gameObject.AddComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(centralSphere != null && orbit != null)
        {

            lineRenderer.SetPosition(0, centralSphere.transform.position);
            lineRenderer.SetPosition(1, orbit.transform.position);
            Debug.Log(orbitPosition + " Position");
            Debug.Log(csPosition + " Position");
        }
    }
}
