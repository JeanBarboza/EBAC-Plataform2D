using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Barboza.Core.Singleton;
using TMPro;

public class ItemManager : Singleton<ItemManager>
{
    public Player player;
    public string checkCoin = "Coin";
    public string checkRocket = "Rocket";
    public SOInt coins;
    public SOInt rocket;

    [Header("Points")]
    public TextMeshProUGUI uiPoints;
    public TextMeshProUGUI uiRocket;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == checkCoin)
        {
            AddCoins();
        }
        else if (collision.transform.tag == checkRocket)
        {
            AddRocket();
        }


    }

    public void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins.value = 0;
        rocket.value = 0;
    }



    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
    }

    public void AddRocket(int r = 1)
    {
        rocket.value += r;
    }

}
