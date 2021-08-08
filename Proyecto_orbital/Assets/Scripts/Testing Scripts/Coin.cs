using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int playerCoins = 0;
    public int[] valueCoins = {1,5,15};
    GameController gameController;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Orbital"))
        {
            PickedPlayerCoin();
            Destroy(gameObject);
        }

    }
    public void PickedPlayerCoin()
    {
        bool playerPickedCoin = true;
        int coinNum = Random.Range(0, 2);
        playerCoins = valueCoins[coinNum];
        Debug.Log("El jugador ha conseguido " + playerCoins + " monedas");
        Debug.Log("El numero es " + valueCoins + " monedas");
        while(playerPickedCoin)
        {
            gameController.AddCoins(playerCoins);
            playerPickedCoin = false;
        }
        
    }

    public static int ConvertPointsToCoins (int pScore)
    {
        int sc = pScore / 100;
        return playerCoins =+ sc;
    }

}
