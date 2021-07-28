using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOffSet : MonoBehaviour
{
    [Header("Variables que definirán la posición de la cámara")]
    [SerializeField] private float yOffset;
    [SerializeField] private float zOffset;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 targetPosition;
    [SerializeField] private float cameraSpeed;

    [Header("Variables para el efecto Shaking")]
    private Vector3 preShakingPosition;
    private bool shaking;
    private float shakingTime;
    [SerializeField] private float shakeAmount;
    [SerializeField] private float shakeDuration;

    private void Update()
    {
        targetPosition = new Vector3(target.transform.position.x, target.transform.position.y + yOffset, target.transform.position.z + zOffset);
        //Se activa al hacer el efecto de cámara golpeando contra algo.
        if (shaking)
        {
            if (shakingTime > 0)
            {
                transform.localPosition = preShakingPosition + Random.insideUnitSphere * shakeAmount;
                shakingTime -= Time.deltaTime;
            }
            else
            {
                shaking = false;
                shakingTime = 0;
                this.transform.localPosition = preShakingPosition;
            }
        }

    }
    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, cameraSpeed*Time.deltaTime);
    }

    public void Shake()
    {
        shaking = true;
        preShakingPosition = this.transform.localPosition;
        shakingTime = shakeDuration;
    }
}
