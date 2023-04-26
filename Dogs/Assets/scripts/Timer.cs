using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI messageText;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public AudioClip backgroundClip;
    
    private bool isTimerRunning = true;
    private bool playedSound = false;

    void Update()
    {
        if (isTimerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                
                if (!playedSound && timeRemaining <= 15f)
                {
                    playedSound = true;
                    audioSource.PlayOneShot(audioClip);
                }
            }
            else
            {
                isTimerRunning = false;
                timeRemaining = 0;
                DisplayTime(timeRemaining);
                messageText.text = "Time's up!";
                audioSource.Stop();
                audioSource.clip = backgroundClip;
                audioSource.Play();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
