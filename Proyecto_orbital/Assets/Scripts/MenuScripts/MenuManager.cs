using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [Header("Variables de texto del panel de arriba")]
    [SerializeField] private TMP_Text premiumText;
    [SerializeField] private TMP_Text hiScoreText;

    [Header("Paneles")]
    [SerializeField] private GameObject[] panels;

    private void Start()
    {
        RefreshUI();
    }
    /// <summary>
    /// M�todo que se encarga de refrescar la interfaz.
    /// </summary>
    private void RefreshUI()
    {
        premiumText.text = GameManager.instance.Player.coins.ToString();
        hiScoreText.text = "Hi-Score: " + GameManager.instance.Player.hiScore;
    }
    /// <summary>
    /// M�todo que cierra la pesta�a donde se pulsa el bot�n "close".
    /// </summary>
    /// <param name="index">Indica la pesta�a a cerrar.</param>
    public void ClosePanel(int index)
    {
        panels[index].SetActive(false);
    }
    public void OpenPanel(int index)
    {
        panels[index].SetActive(true);
    }
}
