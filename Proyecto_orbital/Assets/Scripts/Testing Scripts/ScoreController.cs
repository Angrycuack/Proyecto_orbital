using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public float minDistancePoints = 2.5f;
    /// <summary>
    /// Cuando el orbital pasa muy cerca de un muro
    /// </summary>
    public void PointsOrbitClosetoWall ()
    {


    }

    /// <summary>
    /// Por distancia recorrida
    /// </summary>
    public void PointsTraveledDistance ()
    {

    }

    /// <summary>
    /// Tras pasar 5 segundos sin tocar la pantalla
    /// </summary>
    public void PointsNotTouchingScreen ()
    {

    }

    /// <summary>
    /// Tras pasar 1 minuto sin recibir ningún golpe
    /// </summary>
    public void PointsSpendTimeNotHit ()
    {

    }
}
