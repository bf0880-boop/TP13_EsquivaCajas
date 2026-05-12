using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    float tiempo;
    bool gameOver = false;

    void Update()
    {
        if (!gameOver)
        {
            tiempo += Time.deltaTime;

            timerText.text = tiempo.ToString("F2");
        }
    }

    public void StopTimer()
    {
        gameOver = true;
    }
}