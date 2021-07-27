using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapWall : MonoBehaviour
{
    //Generamos variables para saber si el objeto está activo o no y también para desactivarlo.
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
        //Cada vez que se pulsa el ratón, se desactiva/activa la visual del objeto 
        //y su collider en función del estado en el que se encuentre.
        if (Input.GetMouseButtonDown(0))
        {
            active = !active;
            visibleWall.enabled = active;
            wallCollider.enabled = active;
        }
    }
}
