using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int playerCoins = 0;
    public int[] valueCoinOne = new int[5] {1, 5, 10, 15, 20};
    public void PickedPlayerCoin()
    {
        int coinNum = Random.Range(0, valueCoinOne.Length+1);
        playerCoins  =+ valueCoinOne[coinNum];
        Debug.Log("El jugador ha conseguido " + playerCoins + " monedas");
        Debug.Log("El numero es " + coinNum + " monedas");
    }

}
