using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitDetector : MonoBehaviour
{
    private int pointsToAdd = 10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Orbital")
        {
            Debug.Log(other.gameObject.tag + " detected");

            ScoreController.PointsWhenOrbitClosetoWall(pointsToAdd);
        }
        
    }
}