using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int playerCoins = 0;
    [SerializeField]
    public int[] valueCoinOne;
    public void PickedPlayerCoin()
    {
        int coinNum = Random.Range(0, valueCoinOne.Length);
        playerCoins += valueCoinOne[coinNum];
        Debug.Log("El jugador ha conseguido " + playerCoins + " monedas");
        Debug.Log("El numero es " + coinNum + " monedas");
    }

}
