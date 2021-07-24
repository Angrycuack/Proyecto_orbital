using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsSpawner : MonoBehaviour
{
    public GameObject[] wallsArray;
    private float timeCurrentPlayerPosition;
    private Vector3 currentPlayerPosition;
    private Vector3 lastPlayerPosition;
    private float pointsToSpawnWall;
    private int indexWalls = 0; 
    public GameObject Player;

    private string nameWall;

    float cdTimer = 2f;
    void Start()
    {
        lastPlayerPosition = Player.transform.position;
        StartCoroutine(WallSpawnIn());

    }
    void Update()
    {
        currentPlayerPosition = Player.transform.position;
        CountWalls();
        if (cdTimer > 0)
        {
            cdTimer -= Time.deltaTime;
        }
    }

    IEnumerator WallSpawnIn ()
    {
            

        while (true)
        {

            SpawnMovWalls();
            SpawnOrbitWall();
            SpawnRotateWall();
            yield return new WaitForSeconds(timeCurrentPlayerPosition);

            // destruye los muros creados cuando pase la bola.
        }
            
  
        




    }

    private void CountWalls()
    {
       
;
    }

    private void SpawnMovWalls ()
    {
        float randX = Random.Range(-10f, 10f);
        float randZ = Random.Range(5f, 10f);
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition.z + randZ);
        if (indexWalls <= 1)
        {
            Instantiate(wallsArray[0], pointsToSpawnWall, Quaternion.identity);
            Debug.Log(wallsArray[0]);
        }
        timeCurrentPlayerPosition = currentPlayerPosition.z * Random.Range(1f, 20f);
    }

    private void SpawnOrbitWall ()
    {
        float randX = Random.Range(-10f, 10f);
        float randZ = Random.Range(5f, 10f);
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition.z + randZ);
        if (indexWalls <= 1)
        {
            Instantiate(wallsArray[1], pointsToSpawnWall, Quaternion.identity);
            Debug.Log(wallsArray[1]);
        }
        timeCurrentPlayerPosition = currentPlayerPosition.z * Random.Range(1f, 10f);
    }

    private void SpawnRotateWall()
    {
        float randX = Random.Range(-10f, 10f);
        float randZ = Random.Range(5f, 10f);
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition.z + randZ);
        if (indexWalls <= 1)
        {
            Instantiate(wallsArray[2], pointsToSpawnWall, Quaternion.identity);
            Debug.Log(wallsArray[2]);
        }
        timeCurrentPlayerPosition = currentPlayerPosition.z * Random.Range(1f, 10f);
    }
}
