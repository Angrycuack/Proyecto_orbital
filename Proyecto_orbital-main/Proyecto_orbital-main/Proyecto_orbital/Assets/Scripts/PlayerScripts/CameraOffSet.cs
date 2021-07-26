using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOffSet : MonoBehaviour
{
    [Header("Variables que definir�n la posici�n de la c�mara")]
    private float yOffset;
    private float zOffset;
    [SerializeField] private Transform target;

    private void Start()
    {
        yOffset = 5f;
        zOffset = -10f;
    }

    private void Update()
    {
        this.transform.position = new Vector3(transform.position.x, target.transform.position.y + yOffset, target.transform.position.z + zOffset);
    }
}
