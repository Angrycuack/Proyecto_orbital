using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    
    public static float pointsToAddCloseWall = 10;
    public static float playerScore;
    /// <summary>
    /// Cuando el orbital pasa muy cerca de un muro
    /// </summary>
    public static void PointsWhenOrbitClosetoWall()
    {
        Debug.LogError("No points to add");
    }

    /// <summary>
    /// Por distancia recorrida
    /// </summary>
    public static void PointsTraveledDistance (float distanceScore)
    {
        playerScore = distanceScore;
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
