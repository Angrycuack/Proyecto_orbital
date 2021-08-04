using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text coinText;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] ScoreController scoreController;
    private float score;
    public int orbitNumber;
    public int playerScoreToPrint;

    private void Awake()
    {
        score = 0f;
        instance = this;
        //No es necesario crear un new ya que no es una clase, si no un monobehaviour.
        //scoreController = new ScoreController();
        
    }
    private void Update()
    {
        score += Time.deltaTime;

        //scoreText.text = "Score: " + score.ToString("F0");
        playerScoreToPrint = ScoreController.ScoreToPrint();
        scoreText.text = playerScoreToPrint.ToString();
        coinText.text = "Coins: " + Coin.playerCoins.ToString();
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
    /// <summary>
    /// Método que se encarga de activar el panel de Game Over.
    /// </summary>
    public void GameOver()
    {
        if (orbitNumber <= 0)
        {
            CentralSphereMovement fadeOut = GameObject.FindGameObjectWithTag("Player").GetComponent<CentralSphereMovement>();
            fadeOut.FadeOutEffect();
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            Debug.Log("Game Over");
        }       
    }

    public void AddOrbit(bool add)
    {
        if (add) { orbitNumber++; }
        else { orbitNumber--; GameOver(); }
    }
}
