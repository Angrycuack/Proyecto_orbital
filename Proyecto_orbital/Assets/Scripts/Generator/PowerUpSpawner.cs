using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [Header ("Asignar prefabs de los powerUps y cantidad")]
    [SerializeField] public GameObject DestructionPU;
    [SerializeField] public int sizeDestructionPU;
    GameObject[] poolDestructionPU; // grupacion
    [SerializeField] public GameObject FrostPU;
    [SerializeField] public int sizeFrostPU;
    GameObject[] poolFrostPU; // grupacion
    [SerializeField] public GameObject GhostPU;
    [SerializeField] public int sizeGhostPU;
    GameObject[] poolGhostPU; // grupacion
    [SerializeField] public GameObject MultiplePU;
    [SerializeField] public int sizeMultiplePU;
    GameObject[] poolMultiplePU; // grupacion
    [SerializeField] public GameObject NearPU;
    [SerializeField] public int sizeNearPU;
    GameObject[] poolNearPU; // grupacion
    [SerializeField] public GameObject SpeedPU;
    [SerializeField] public int sizeSpeedPU;
    GameObject[] poolSpeedPU; // grupacion

    


    [Header ("Asignar el Jugador y el target position final")]
    public GameObject player;
    Vector3 playerPosition;

    public GameObject target;
    Vector3 targetEndPosition;

    //private bool go = true;
    void Awake()
    {
        player = GameObject.Find("Player 1");
        playerPosition = player.transform.position;
        target = GameObject.Find("Final WayPoints");
        targetEndPosition = target.transform.position;
        PowerUpsRecharger();
    }



    void Start()
    {
        Debug.Log("Posicion del jugador" + playerPosition);
        Debug.Log("Posicion target " + targetEndPosition);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Se inicializa con el numero de powerUps asignado.
    /// </summary>
    void PowerUpsRecharger()
    {
        poolDestructionPU = new GameObject[sizeDestructionPU];

        for(int i = 0; i < poolDestructionPU.Length; i++)
        {
            float posZ = targetEndPosition.z;
            
            float randomPosition = Random.Range(0, posZ);
            if(i < sizeDestructionPU)
            {
                poolDestructionPU[i] = Instantiate(DestructionPU, new Vector3(0, 0, randomPosition), Quaternion.identity);
                poolDestructionPU[i].SetActive(true);
            }
            
            
        }

    }

}
