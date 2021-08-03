using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_game : MonoBehaviour
{

    public GameObject Menu;
    public GameObject Juego;
    bool changecanvas;

    public PlayerMoves player;

    public Button yourButton;


    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(change);
    }

    public void change ()
    {
        Menu.SetActive(false);
        Juego.SetActive(true);
        player.speed = 0.06f;
    
    }

}
