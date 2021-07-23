using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls : MonoBehaviour
{
    // Una lista de los walls en prefab.
    [SerializeField]
    GameObject staticWall;

  

    // Asignar una variable indice = 0;
    int startingWalls = 0;

    // Walls
    int numWalls = 5; // numero de muros 
 
    void Start()
    {

        // Asignar una variable el estado currentWalls
        var currentWalls = startingWalls;
        // StartCoroutine(SpawnWallsIn(currentWalls));
        StartCoroutine(SpawnWallsIn(currentWalls));
        

    }

    void Update()
    {
        
    }

    IEnumerator SpawnWallsIn (int currentWalls)
    {
       
        // variable int countWall = 0; countWall < variable numero de walls (asignado), countWall++)
        // otra opcion - apareceran muros cuando este la orbita a X posicion.
        // Instantiate(wall, position aleatoria, Quaternion.identity);
        for (int countWalls = 0; countWalls <  numWalls; countWalls++)
        {
            // usar algoritmo
            float valueX = Random.Range(0, 10);
            float valueZ = Random.Range(0, 5);
            Instantiate(staticWall, new Vector3(valueX, 0, valueZ), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        
    }
}
