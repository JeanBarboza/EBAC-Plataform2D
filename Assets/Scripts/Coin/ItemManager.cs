using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Barboza.Core.Singleton;
using TMPro;

public class ItemManager : Singleton<ItemManager>
{
    public Player player;
    public string checkCoin = "Coin";
    public SOInt coins;

    [Header("Points")]
    public TextMeshProUGUI uiPoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == checkCoin)
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
        coins.value = 0;
    }


    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
    }
}
