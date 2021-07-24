using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private GameObject pausePanel;
    private float score;

    private void Start()
    {
        score = 0f;
    }
    private void Update()
    {
        score += Time.deltaTime;
        scoreText.text = "Score: " + score.ToString("F0");
    }
    /// <summary>
    /// Método que devuelve al jugador a la pantalla de Menú.
    /// </summary>
    public void GoToMenu()
    {
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// Método que abre o cierra el panel de Pausa y adecua el tiempo a pausado o activo.
    /// </summary>
    /// <param name="state">Activar o desactivar pausa.</param>
    public void PauseGame(bool state)
    {
        pausePanel.SetActive(state);
        if (state) { Time.timeScale = 0; }
        else { Time.timeScale = 1; }
    }
}
