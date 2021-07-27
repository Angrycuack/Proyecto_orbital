using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalMovement : MonoBehaviour
{
    [SerializeField] private Transform centralSphere;
    private static float speed;
    private float basicSpeed = 30f;
    private bool rotateUp;
    private static bool timer;
    private float countDown = 10f;
    private Vector3 direction;
    

    private void Start()
    {
        centralSphere = GameObject.Find("CentralSphere").transform;
        this.gameObject.transform.SetParent(centralSphere);
        rotateUp = true;
        ReturnSpeed();
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
        if (timer) { countDown -= Time.deltaTime; }
        if (countDown <= 0) { ReturnSpeed(); }
    }
    private void FixedUpdate()
    {
        transform.RotateAround(centralSphere.transform.position, direction, speed * Time.deltaTime);
        Debug.Log(speed);
    }
    /// <summary>
    /// M�todo que se encarga de aumentar o disminuar la velocidad del orbital.
    /// </summary>
    /// <param name="up_down">Indica si hay que aumentar la velocidad o parar el orbital.</param>
    public void SpeedUp(bool up_down)
    {
        if (up_down) { speed *= 3; }
        else { speed = 0; }
        timer = true;
    }
    /// <summary>
    /// Se encarga de devolver la velocidad del orbital al valor original.
    /// </summary>
    private void ReturnSpeed()
    {
        speed = basicSpeed;
        countDown = 10f;
        timer = false;
    }
}
