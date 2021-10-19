using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public string tagToCompare = "Player";

    public GameObject uiEndGame;
    public GameObject uiHud;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(tagToCompare))
        {
            CallEndGame();
            SwitchOffHud();
            Pause();
        }
    }

    public void CallEndGame()
    {
        uiEndGame.SetActive(true);
    }

    public void SwitchOffHud()
    {
        uiHud.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }
}
