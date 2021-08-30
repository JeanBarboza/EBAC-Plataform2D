using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Barboza.Core.Singleton;
using UnityEngine.UI;
using TMPro;

public class ItemManager : Singleton<ItemManager>
{
    public Player player;
    public string checkTag = "Coin";
    public int coins;

    [Header("Points")]
    public TextMeshProUGUI uiPoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == checkTag)
        {
            AddCoins();
        }
    }

    public void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins = 0;
        UpdateUI();
    }

    public void AddCoins(int amount = 1)
    {
        coins += amount;
        UpdateUI();
    }


    private void UpdateUI()
    {
        uiPoints.text = coins.ToString();
    }
}
