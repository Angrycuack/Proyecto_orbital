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
<<<<<<< HEAD:Proyecto_orbital/Assets/Scripts/Generator/WallsSpawner.cs

    [SerializeField] private float whenToSpawnWall;
    private float timer;
    //float cdTimer = 2f;
=======
    //int timeAdd
    public float timeToWait;
    private string nameWall;
>>>>>>> 600d31384a5317ce811b16045e9a30abde04559b:Proyecto_orbitalOld/Assets/Scripts/Generator/WallsSpawner.cs

    private int getWallsCount;
    void Start()
    {
        lastPlayerPosition = Player.transform.position;
        StartCoroutine(WallSpawnIn());

    }
    void FixedUpdate()
    {
        currentPlayerPosition = Player.transform.position.z;
<<<<<<< HEAD:Proyecto_orbital/Assets/Scripts/Generator/WallsSpawner.cs
        //Debug.Log("Posicion del jugador " + currentPlayerPosition);
        getWallsCount = CountWalls();
=======
        CountWalls();
        //Debug.Log(Time.time);
>>>>>>> 600d31384a5317ce811b16045e9a30abde04559b:Proyecto_orbitalOld/Assets/Scripts/Generator/WallsSpawner.cs
        //if (cdTimer > 0)
        //{
        //    cdTimer -= Time.deltaTime;
        //}
<<<<<<< HEAD:Proyecto_orbital/Assets/Scripts/Generator/WallsSpawner.cs

        timer = Time.time;
        Debug.Log("Time: " + timer);
    }
    void FixedUpdate ()
    {
        DestroySpawnedWalls();
=======
        //WallSpawnIn();
>>>>>>> 600d31384a5317ce811b16045e9a30abde04559b:Proyecto_orbitalOld/Assets/Scripts/Generator/WallsSpawner.cs
    }

    IEnumerator WallSpawnIn ()
    {
<<<<<<< HEAD:Proyecto_orbital/Assets/Scripts/Generator/WallsSpawner.cs
        
        bool WallSpawned = false;
        while (!WallSpawned)
        {
            if (getWallsCount <= 10)
            {

                    SpawnMovWalls();
                                
            }
            if (getWallsCount <= 10)
            {
                SpawnOrbitWall();
=======
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
>>>>>>> 600d31384a5317ce811b16045e9a30abde04559b:Proyecto_orbitalOld/Assets/Scripts/Generator/WallsSpawner.cs
            }
            

<<<<<<< HEAD:Proyecto_orbital/Assets/Scripts/Generator/WallsSpawner.cs
            //SpawnRotateWall();
=======
            if (Time.time > timeToWait + 5)
            {
                SpawnTapWalls(); //
                timeToWait = timeToWait + 3f;
            }
>>>>>>> 600d31384a5317ce811b16045e9a30abde04559b:Proyecto_orbitalOld/Assets/Scripts/Generator/WallsSpawner.cs

            //SpawnStaticWalls();

<<<<<<< HEAD:Proyecto_orbital/Assets/Scripts/Generator/WallsSpawner.cs
            //SpawnTapWalls();

            yield return new WaitForSeconds(timeCurrentPlayerPosition);

            // destruye los muros creados cuando pase la bola.
            // cuando se van los muros vienen los nuevos.
            int getWalls = getWallsCount;
            Debug.Log(getWalls);
            if (getWalls == 30)
            {
                WallSpawned = true;
            }

=======

            // destruye los muros creados cuando pase la bola.
            // cuando se van los muros vienen los nuevos.
            // cuando muere el player return false para parar el loop
            if (getWalls == 50)
            {
                wallsSpawned = true;
            }
            yield return null;
            Debug.Log("Han aparecido todas " + wallsSpawned);
>>>>>>> 600d31384a5317ce811b16045e9a30abde04559b:Proyecto_orbitalOld/Assets/Scripts/Generator/WallsSpawner.cs
        }

    }

    private int CountWalls()
    {
        wallsCounted = GameObject.FindGameObjectsWithTag("Enemy").Length;
        // Debug.Log(wallsCounted);
        return wallsCounted;
;
    }
    
    private void DestroySpawnedWalls()
    {
        if (getWallsCount == 1)
        {
            Debug.Log("Destroy one wall");
        }
    }

    private void SpawnMovWalls ()
    {
<<<<<<< HEAD:Proyecto_orbital/Assets/Scripts/Generator/WallsSpawner.cs
        float randX = Random.Range(-5f, 5f);
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition);

        Instantiate(wallsArray[0], pointsToSpawnWall, Quaternion.identity);
        Debug.Log(wallsArray[0]);

        timeCurrentPlayerPosition = currentPlayerPosition + Random.Range(0.5f, 2f); // Posicion ahora de la bola añadimos unos segundos para el cooldown

=======
        float randX = Random.Range(-10f, 10f);
        float randZ = Random.Range(5f, 10f);
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition + randZ);

        
        Instantiate(wallsArray[0], pointsToSpawnWall, Quaternion.identity);
        Debug.Log(wallsArray[0]);
        

        //timeCurrentPlayerPosition = currentPlayerPosition + Random.Range(1f, 10f); // Posicion ahora de la bola añadimos unos segundos para el cooldown
        //if (timeCurrentPlayerPosition > currentPlayerPosition)
        //{
        //    Instantiate(wallsArray[0], pointsToSpawnWall, Quaternion.identity);
        //    Debug.Log(wallsArray[0]);
        //}
>>>>>>> 600d31384a5317ce811b16045e9a30abde04559b:Proyecto_orbitalOld/Assets/Scripts/Generator/WallsSpawner.cs
    }

    private void SpawnOrbitWall ()
    {
        float randX = Random.Range(-5f, 5f);
        float randZ = Random.Range(5f, 10f);
<<<<<<< HEAD:Proyecto_orbital/Assets/Scripts/Generator/WallsSpawner.cs
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition);

        Instantiate(wallsArray[1], pointsToSpawnWall, Quaternion.identity);
        Debug.Log(wallsArray[1]);
  
        timeCurrentPlayerPosition = currentPlayerPosition + Random.Range(0.5f, 2f);
=======
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition + randZ);

        
        Instantiate(wallsArray[1], pointsToSpawnWall, Quaternion.identity);
        Debug.Log(wallsArray[1]);
        
        //timeCurrentPlayerPosition = currentPlayerPosition + Random.Range(1f, 10f);
>>>>>>> 600d31384a5317ce811b16045e9a30abde04559b:Proyecto_orbitalOld/Assets/Scripts/Generator/WallsSpawner.cs
    }

    private void SpawnRotateWall()
    {
        float randX = Random.Range(-5f, 5f); // Genera muros de izq a der
        float randZ = Random.Range(5f, 10f); 
<<<<<<< HEAD:Proyecto_orbital/Assets/Scripts/Generator/WallsSpawner.cs
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition);

        Instantiate(wallsArray[2], pointsToSpawnWall, Quaternion.identity);
        Debug.Log(wallsArray[2]);

        timeCurrentPlayerPosition = currentPlayerPosition * Random.Range(1f, 5f);
=======
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition + randZ);
        
        Instantiate(wallsArray[2], pointsToSpawnWall, Quaternion.identity);
        Debug.Log(wallsArray[2]);
        //timeCurrentPlayerPosition = currentPlayerPosition * Random.Range(1f, 10f);
>>>>>>> 600d31384a5317ce811b16045e9a30abde04559b:Proyecto_orbitalOld/Assets/Scripts/Generator/WallsSpawner.cs
    }

    private void SpawnStaticWalls()
    {
        float randX = Random.Range(-10f, 10f);
        float randZ = Random.Range(5f, 10f);
<<<<<<< HEAD:Proyecto_orbital/Assets/Scripts/Generator/WallsSpawner.cs
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition);

       
        Instantiate(wallsArray[3], pointsToSpawnWall, Quaternion.identity);
        Debug.Log(wallsArray[3]);
        
        timeCurrentPlayerPosition = currentPlayerPosition * Random.Range(1f, 5f);
=======
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
>>>>>>> 600d31384a5317ce811b16045e9a30abde04559b:Proyecto_orbitalOld/Assets/Scripts/Generator/WallsSpawner.cs
    }

    private void SpawnTapWalls()
    {
        float randX = Random.Range(-10f, 10f);
        float randZ = Random.Range(5f, 10f);
<<<<<<< HEAD:Proyecto_orbital/Assets/Scripts/Generator/WallsSpawner.cs
        Vector3 pointsToSpawnWall = new Vector3(randX, 0, currentPlayerPosition);

        Instantiate(wallsArray[4], pointsToSpawnWall, Quaternion.identity);
        Debug.Log(wallsArray[4]);
       
        timeCurrentPlayerPosition = currentPlayerPosition * Random.Range(1f, 5f);

=======
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
>>>>>>> 600d31384a5317ce811b16045e9a30abde04559b:Proyecto_orbitalOld/Assets/Scripts/Generator/WallsSpawner.cs
    }
}
