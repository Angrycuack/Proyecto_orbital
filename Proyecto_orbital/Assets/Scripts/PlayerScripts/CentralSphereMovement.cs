using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralSphereMovement : MonoBehaviour
{
    public float speed;
    private Vector3 spawnPosition;
    [SerializeField] private GameObject centralSphere;
    [SerializeField] private GameObject orbital;


    private void Start()
    {
        spawnPosition = new Vector3(centralSphere.transform.position.x, centralSphere.transform.position.y, centralSphere.transform.position.z - 3f);
        Instantiate(orbital, spawnPosition, orbital.transform.rotation);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }
}
