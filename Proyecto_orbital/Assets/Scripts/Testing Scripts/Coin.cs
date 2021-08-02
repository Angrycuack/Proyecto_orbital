using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    public static int playerCoins = 0;
    private int coinValue = 2;
    void Start()
    {
        coin = GameObject.FindGameObjectWithTag("Coin");
    }
    

    public void PickedPlayerCoin()
    {
        coinValue = Random.Range(0, 2);
        switch(coinValue)
        {
            case 1:
                playerCoins = playerCoins + 5;
                break;
            case 2:
                playerCoins = playerCoins + 15;
                break;
            default:
                playerCoins = playerCoins + 1;
                break;

        }
        Debug.Log("El jugador ha conseguido " + playerCoins + " monedas");
        Debug.Log("El jugador ha conseguido " + coinValue + " monedas");

    }

}
