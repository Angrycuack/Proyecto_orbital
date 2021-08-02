using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    public static int playerCoins = 0;
    [SerializeField]
    public static int valueCoinOne = 5;
    [SerializeField]
    public static int valueCoinTwo = 10;
    [SerializeField]
    public static int valueCoinThree = 15;
    private int coinCount = 4;
    void Start()
    {
        coin = GameObject.FindGameObjectWithTag("Coin");
    }
    

    public void PickedPlayerCoin()
    {
        int coinNum = Random.Range(0, coinCount+1);
        switch(coinNum)
        {
            case 1:
                playerCoins = playerCoins + valueCoinOne;
                break;
            case 2:
                playerCoins = playerCoins + valueCoinTwo;
                break;
            case 3:
                playerCoins = playerCoins + valueCoinThree;
                break;
            default:
                playerCoins = playerCoins + 1;
                break;

        }
        Debug.Log("El jugador ha conseguido " + playerCoins + " monedas");
        Debug.Log("El numero es " + coinNum + " monedas");

    }

}
