using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [Header("Variables de texto del panel de arriba")]
    [SerializeField] private TMP_Text moneyText;
    [SerializeField] private TMP_Text premiumText;

    private void Start()
    {
        RefreshUI();
    }

    private void RefreshUI()
    {
        moneyText.text = GameManager.instance.Player.money.ToString();
        premiumText.text = GameManager.instance.Player.premium.ToString();
    }
}
