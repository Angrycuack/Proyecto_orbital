using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalMovement : MonoBehaviour
{
    [SerializeField] private Transform centralSphere;
    [SerializeField] private float speed;
    private bool rotateUp;
    private Vector3 direction;
    

    private void Start()
    {
        centralSphere = GameObject.Find("CentralSphere").transform;
        this.gameObject.transform.SetParent(centralSphere);
        rotateUp = true;
        direction = Vector3.up;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!rotateUp) { direction = Vector3.up; }
            if (rotateUp) { direction = Vector3.down; }
            rotateUp = !rotateUp;
        }
    }
    private void FixedUpdate()
    {
        transform.RotateAround(centralSphere.transform.position, direction, speed * Time.deltaTime);
    }
}
