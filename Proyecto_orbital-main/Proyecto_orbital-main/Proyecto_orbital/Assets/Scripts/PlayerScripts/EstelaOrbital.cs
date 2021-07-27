using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstelaOrbital : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Estela;

    Vector3 positionEstela;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        positionEstela = Estela.transform.position;
    }
}
