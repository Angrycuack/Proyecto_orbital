using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [Header("Variables que definirán la cantidad de muro en la escena")]
    [SerializeField] private int numMovWalls;
    [SerializeField] private int numIronWalls;
    [SerializeField] private int numRotateWalls;
    [SerializeField] private int numStaticWalls;
    [SerializeField] private int numTapWall;
    
    [Header("Variables que definiran la cantidad de power ups en la escena")]
    [SerializeField] private int numDestructionPUs;
    [SerializeField] private int numFrostPUs;
    [SerializeField] private int numGhostPUs;
    [SerializeField] private int numMultiplePUs;
    [SerializeField] private int numNearPUs;
    [SerializeField] private int numSpeedPUs;


}
