using System.Collections;
using UnityEngine;
using TMPro; // Ajoute ceci

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText; // À assigner dans l’Inspector
    public float timeRemaining = 600f; // 10 minutes en secondes

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining < 0)
                timeRemaining = 0;
        }

        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}