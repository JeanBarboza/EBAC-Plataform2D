using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Barboza.Core.Singleton;

public class UIInGameManager : Singleton<UIInGameManager>
{
    public TextMeshProUGUI uiTextCoins;
    public TextMeshProUGUI uiTextRocket;

    public static void UpdateTextCoins(string s)
    {
        Instance.uiTextCoins.text = s;
    }

    public static void UpdateTextRockets(string r)
    {
        Instance.uiTextCoins.text = r;
    }
}
