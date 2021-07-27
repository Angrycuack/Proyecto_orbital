using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralSphereMovement : MonoBehaviour
{
    //Variables de velocidad y posición para la instanciación de nuevos orbitales.
    //public float speed;
    private Vector3 spawnPosition;

    //Variables de posiciones y prefabs de objetos.
    [SerializeField] private GameObject centralSphere;
    [SerializeField] private GameObject orbital;

    private void Start()
    {
        spawnPosition = new Vector3(centralSphere.transform.position.x, centralSphere.transform.position.y, centralSphere.transform.position.z - 3f);
        StartCoroutine(MultipleBall(1));
    }

    private void Update()
    {
        //transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }

    /// <summary>
    /// Método que se encarga de iniciar las corrutinas de Power Up.
    /// </summary>
    public void PowerUp()
    {
        StartCoroutine(MultipleBall(2));
    }

    /// <summary>
    /// Corrutina que genera dos orbitales nuevos en un espacio de tiempo variable de 1 a 3 segundos.
    /// </summary>
    /// <returns></returns>
    IEnumerator MultipleBall(int number)
    {
        for(int i = 0; i< number; i++)
        {
            Instantiate(orbital, spawnPosition, orbital.transform.rotation);
            GameController.instance.AddOrbit(true);
            yield return new WaitForSeconds(Random.Range(1f,3f));
        }
        
    }
}
