using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapWall : MonoBehaviour
{
    //Generamos variables para saber si el objeto est� activo o no y tambi�n para desactivarlo.
    public bool active;
    private MeshRenderer visibleWall;
    private BoxCollider wallCollider;
    public Material visible;
    public Material invisible;

    private void Start()
    {
        //Inicializamos la variables con el valor que queremos que tengan por defecto.
        visibleWall = GetComponent<MeshRenderer>();
        wallCollider = GetComponent<BoxCollider>();
    }



    void Update()
    {
        //Cada vez que se pulsa el rat�n, se desactiva/activa la visual del objeto 
        //y su collider en funci�n del estado en el que se encuentre.
        if (Input.GetMouseButtonDown(0))
        {
            active = !active;
            if (active == true)
            {
                GetComponent<MeshRenderer>().material = visible;
            }
            else
            {
                GetComponent<MeshRenderer>().material = invisible;
            }
            
            wallCollider.enabled = active;
        }
    }
}
