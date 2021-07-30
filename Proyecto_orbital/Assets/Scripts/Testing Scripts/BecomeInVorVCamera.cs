using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeInVorVCamera : MonoBehaviour
{ 
    private void OnBecameVisible()
    {
    Debug.Log("este prefabas esta dentro de la camera y visible");
    }
    private void OnBecameInvisible()
    {
        Debug.Log("este prefabs esta invisible");
        gameObject.SetActive(false);
    }
}
