using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowerUpButton : MonoBehaviour
{
    private string PowerUp;
    private Sprite[] PowerUpImage;
    [SerializeField] private float timerCD;
    [SerializeField] private float PowerUpCD;
    [SerializeField] private bool coolDownActive;
    [SerializeField] private Image image;
    [SerializeField] private GameObject  cD;
    [SerializeField] private TMP_Text cdText;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        coolDownActive = false;
    }

    private void Update()
    {
        if (coolDownActive)
        {
            timerCD -= Time.deltaTime;
            cdText.text = timerCD.ToString("f0");
            if (timerCD <= 0) { ActivePU(false); }
        }
    }
    public void RefreshButton(string power)
    {
        PowerUp = power;
        PowerUpCD = 10f;
    }
    public void ActivePU(bool state)
    {
        cD.SetActive(state);
        button.enabled = !state;
        coolDownActive = state;
        timerCD = PowerUpCD;
    }
}
