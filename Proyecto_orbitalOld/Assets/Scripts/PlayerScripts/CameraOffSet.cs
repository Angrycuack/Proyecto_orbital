using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOffSet : MonoBehaviour
{
    [Header("Variables que definir�n la posici�n de la c�mara")]
    [SerializeField]private float yOffset;
    [SerializeField]private float zOffset;
    [SerializeField] private Transform target;

    private void Update()
    {
        this.transform.position = new Vector3(transform.position.x, target.transform.position.y + yOffset, target.transform.position.z + zOffset);
    }
}
