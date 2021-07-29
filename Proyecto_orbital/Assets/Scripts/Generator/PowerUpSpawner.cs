using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField] public GameObject[] powerUps;
    [SerializeField] public int numberOfPowerUps;

    public GameObject player;
    Vector3 playerPosition;

    public GameObject target;
    Vector3 targetEndPosition;

    //private bool go = true;
    void Awake()
    {
        player = GameObject.Find("Player");
        playerPosition = player.transform.position;
        target = GameObject.Find("TargetPosition");
        targetEndPosition = target.transform.position;
    }
    void Start()
    {
        Debug.Log("Posicion del jugador" + playerPosition);
        Debug.Log("Posicion target " + targetEndPosition);
        PointsGeneratorPowerUps(numberOfPowerUps);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Generar los puntos de apareceran los power ups aleatoriamente
    /// </summary>
    /// <param name="numberOfpowerups"></param>
    void PointsGeneratorPowerUps (int numberOfpowerups)
    {
        
    }
}
