using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapWall : MonoBehaviour
{
    //Generamos variables para saber si el objeto est� activo o no y tambi�n para desactivarlo.
    private bool active;
    private MeshRenderer visibleWall;
    private BoxCollider wallCollider;

    private void Start()
    {
        //Inicializamos la variables con el valor que queremos que tengan por defecto.
        active = true;
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
            visibleWall.enabled = active;
            wallCollider.enabled = active;
        }
    }
}
