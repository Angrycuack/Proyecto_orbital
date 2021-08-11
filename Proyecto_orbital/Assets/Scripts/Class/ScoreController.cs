using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController 
{
    public static int pointsToAddCloseWall;
    private static int poinsToAddNotTouching;
    public static int playerScoreTotal;
    private static int playerDistance;
    public static int c_playerScoreTotal;
    private static int save_PlayerScore;
    private static int playerScore_print;

    /// <summary>
    /// Cuando el orbital pasa muy cerca de un muro
    /// </summary>
    public static void PointsWhenOrbitClosetoWall(int scoretoAdd)
    {
        if (c_playerScoreTotal != playerScoreTotal)
        {
            c_playerScoreTotal = playerScoreTotal + scoretoAdd;
        }
        save_PlayerScore = c_playerScoreTotal;
    }

    /// <summary>
    /// Por distancia recorrida
    /// </summary>
    public static void PointsTraveledDistance (float distanceScore)
    {

        playerDistance = (int) Mathf.Round(distanceScore);
        playerScoreTotal += playerDistance;
        Debug.Log(playerScoreTotal);
    }

    /// <summary>
    /// Tras pasar 5 segundos sin tocar la pantalla
    /// </summary>
    public static void PointsNotTouchingScreen (int scoretoAdd)
    {
        Debug.Log(scoretoAdd + " Puntos");
        Debug.Log(c_playerScoreTotal + " puntos total");
        poinsToAddNotTouching = (int) Mathf.Round(scoretoAdd);
        if(c_playerScoreTotal != playerScoreTotal)
        {
            c_playerScoreTotal += poinsToAddNotTouching;
        }
        save_PlayerScore = c_playerScoreTotal;
    }

    /// <summary>
    /// Tras pasar 1 minuto sin recibir ningún golpe
    /// </summary>
    void PointsSpendTimeNotHit ()
    {

    }

    /// <summary>
    /// Recoge todo el valor de puntos para sumar y manda el valor a imprimir en pantalla score
    /// </summary>
    /// <returns></returns>
    public static int ScoreToPrint()
    {
            
        c_playerScoreTotal = playerScoreTotal + save_PlayerScore;
        playerScore_print = c_playerScoreTotal;
        Coin.ConvertPointsToCoins(c_playerScoreTotal);
        return playerScore_print;
    }
}
