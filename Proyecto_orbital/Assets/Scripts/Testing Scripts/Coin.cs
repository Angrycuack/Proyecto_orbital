using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int playerCoins = 0;
    public static int[] valueCoinOne = { 5, 10, 15 };
    private int coinCount = 4;

    public void PickedPlayerCoin()
    {
        int coinNum = Random.Range(0, coinCount+1);
        playerCoins += valueCoinOne[coinNum];
        Debug.Log("El jugador ha conseguido " + playerCoins + " monedas");
        Debug.Log("El numero es " + coinNum + " monedas");
    }

}
