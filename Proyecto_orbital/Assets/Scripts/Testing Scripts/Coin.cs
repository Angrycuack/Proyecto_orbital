using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    public static int playerCoins = 0;
    void Start()
    {
        coin = GameObject.FindGameObjectWithTag("Coin");
    }
    

    public void PickedPlayerCoin()
    {
        playerCoins++;
        Debug.Log("El jugador ha conseguido " + playerCoins + "monedas");
 
    }

}
