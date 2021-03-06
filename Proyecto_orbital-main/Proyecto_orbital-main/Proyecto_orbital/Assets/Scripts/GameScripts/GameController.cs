using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject gameOverPanel;
    private float score;
    public int orbitNumber;

    private void Awake()
    {
        score = 0f;
        instance = this;
    }
    private void Update()
    {
        score += Time.deltaTime;
        scoreText.text = "Score: " + score.ToString("F0");
    }
    /// <summary>
    /// M?todo que devuelve al jugador a la pantalla de Men?.
    /// </summary>
    public void GoToMenu()
    {
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// M?todo que abre o cierra el panel de Pausa y adecua el tiempo a pausado o activo.
    /// </summary>
    /// <param name="state">Activar o desactivar pausa.</param>
    public void PauseGame(bool state)
    {
        pausePanel.SetActive(state);
        if (state) { Time.timeScale = 0; }
        else { Time.timeScale = 1; }
    }
    /// <summary>
    /// M?todo que se encarga de activar el panel de Game Over.
    /// </summary>
    public void GameOver()
    {
        if (orbitNumber <= 0)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            Debug.Log("Game Over");
        }       
    }

    public void AddOrbit(bool add)
    {
        if (add) { orbitNumber++; }
        else { orbitNumber--; GameOver();}
    }
}
