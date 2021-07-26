using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private Player _player = new Player();
    public Player Player { get { return _player; } set { _player = value; } }

    private void Awake()
    {
        instance = this;
    }

    public void Save()
    {
        string saveGame = JsonUtility.ToJson(Player);
        PlayerPrefs.SetString("Player", saveGame);
    }
}
