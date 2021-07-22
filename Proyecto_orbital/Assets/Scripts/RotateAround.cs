using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [Header("Variables dedicadas al movimiento de orbita del Player")]
    [SerializeField] private Transform target;
    private bool rotateUp;
    private Vector3 direction;
    private float speed;

    private void Start()
    {
        speed = 50f;
        rotateUp = true;
        direction = Vector3.up;
    }
    void Update()
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
        transform.RotateAround(target.transform.position, direction, speed * Time.deltaTime);
    }
}
