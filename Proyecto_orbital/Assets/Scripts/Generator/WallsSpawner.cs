using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsSpawner : MonoBehaviour
{
    public GameObject[] wallsArray;
    private float timeCurrentPlayerPosition;
    private float currentPlayerPosition;
    private Vector3 lastPlayerPosition;
    private float pointsToSpawnWall;
    private int indexWalls = 0;
    private int wallsCounted;
    public GameObject Player;
    //int timeAdd
    public float timeToWait;
    private string nameWall;

    float cdTimer = 2f;
    void Start()
    {
        lastPlayerPosition = Player.transform.position;
        StartCoroutine(WallSpawnIn());

    }
    void FixedUpdate()
    {
        currentPlayerPosition = Player.transform.position.z;
        CountWalls();
        //Debug.Log(Time.time);
        //if (cdTimer > 0)
        //{
        //    cdTimer -= Time.deltaTime;
        //}
        //WallSpawnIn();
    }

    IEnumerator WallSpawnIn ()
    {
        bool wallsSpawned = false;

        Debug.Log("Hay un muro" + wallsSpawned);
        while (!wallsSpawned)
        {
            int getWalls = CountWalls();

            if(Time.time > timeToWait)
            {
                SpawnMovWalls();
                timeToWait = timeToWait + 2f;
            }
            
            if(Time.time > timeToWait+1) // Problema no llega en esta parte
            {
                SpawnOrbitWall();
                timeToWait = timeToWait + 3f;
            }

            if(Time.time > timeToWait+3)
            {
                SpawnRotateWall(); //Aparecen cerca de la linea
                timeToWait = timeToWait + 2f;
            }

            if(Time.time > timeToWait+4)
            {
                SpawnStaticWalls(); //
                timeToWait = timeToWait + 3f;
            }




            //SpawnTapWalls(); Igual que Static Wall

            //yield return new WaitForSeconds(timeCurrentPlayerPosition);

            // destruye los muros creados cuando pase la bola.
            // cuando se van los muros vienen los nuevos.
            // cuando muere el player return false para parar el loop
            if (getWalls == 50)
            {
                wallsSpawned = true;
            }
            yield return null;
            Debug.Log("Han aparecido todas " + wallsSpawned);
        }
    }

    private int CountWalls()
    {
        wallsCounted = GameObject.FindGameObjectsWithTag("Enemy").Length;
        Debug.Log(wallsCounted);
        return wallsCounted;
;
    }
    
    private void DestroySpawnedWalls()
    {
        //Cuando los wall quedan fuera de la pantalla desaparecen
    }

    private void SpawnMovWalls ()
    {
        float randX = Random.Range(-10f, 10f);
        float randZ = Random.Range(5f, 10f);
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition + randZ);
        if (indexWalls <= 1)
        {
            Instantiate(wallsArray[0], pointsToSpawnWall, Quaternion.identity);
            Debug.Log(wallsArray[0]);
        }

        //timeCurrentPlayerPosition = currentPlayerPosition + Random.Range(1f, 10f); // Posicion ahora de la bola añadimos unos segundos para el cooldown
        //if (timeCurrentPlayerPosition > currentPlayerPosition)
        //{
        //    Instantiate(wallsArray[0], pointsToSpawnWall, Quaternion.identity);
        //    Debug.Log(wallsArray[0]);
        //}
    }

    private void SpawnOrbitWall ()
    {
        float randX = Random.Range(-10f, 10f);
        float randZ = Random.Range(5f, 10f);
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition + randZ);
        if (indexWalls <= 1)
        {
            Instantiate(wallsArray[1], pointsToSpawnWall, Quaternion.identity);
            Debug.Log(wallsArray[1]);
        }
        //timeCurrentPlayerPosition = currentPlayerPosition + Random.Range(1f, 10f);
    }

    private void SpawnRotateWall()
    {
        float randX = Random.Range(-5f, 5f); // Genera muros de izq a der
        float randZ = Random.Range(5f, 10f); 
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition + randZ);
        if (indexWalls <= 1)
        {
            Instantiate(wallsArray[2], pointsToSpawnWall, Quaternion.identity);
            Debug.Log(wallsArray[2]);
        }
        //timeCurrentPlayerPosition = currentPlayerPosition * Random.Range(1f, 10f);
    }

    private void SpawnStaticWalls()
    {
        float randX = Random.Range(-10f, 10f);
        float randZ = Random.Range(5f, 10f);
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition + randZ);
        if (indexWalls <= 1)
        {
            Instantiate(wallsArray[3], pointsToSpawnWall, Quaternion.identity);
            Debug.Log(wallsArray[3]);
        }
        //timeCurrentPlayerPosition = currentPlayerPosition * Random.Range(1f, 20f);
        //if (timeCurrentPlayerPosition > currentPlayerPosition)
        //{
        //    Instantiate(wallsArray[3], pointsToSpawnWall, Quaternion.identity);
        //    Debug.Log(wallsArray[3]);
        //}
    }

    private void SpawnTapWalls()
    {
        float randX = Random.Range(-10f, 10f);
        float randZ = Random.Range(5f, 10f);
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition + randZ);
        if (indexWalls <= 1)
        {
            Instantiate(wallsArray[4], pointsToSpawnWall, Quaternion.identity);
            Debug.Log(wallsArray[4]);
        }
        //timeCurrentPlayerPosition = currentPlayerPosition * Random.Range(1f, 20f);
        //if (timeCurrentPlayerPosition > currentPlayerPosition)
        //{
        //    Instantiate(wallsArray[4], pointsToSpawnWall, Quaternion.identity);
        //    Debug.Log(wallsArray[4]);
        //}
    }
}
