using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
    public bool itsTimeToSpawn = false;
    public int lapsInterval = 2;
    public float timeLeft = 300.0f;
    public float timeLeftMemo;
    public bool stop = true;

    private float minutes;
    private float seconds;

    //public Text text;
    public TMP_Text text;
    public GameObject gameOverPanel;
    public GameObject player;
    public PlayerPrefs savingScore;

    private void Start()
    {
        
        gameOverPanel.SetActive(false);
        timeLeftMemo = timeLeft;
        startTimer(timeLeft);
    }

    public void startTimer(float from)
    {
        stop = false;
        timeLeft = from;
        Update();
        StartCoroutine(updateCoroutine());
    }

    void Update()
    {
        if (stop) return;
        timeLeft -= Time.deltaTime;

        minutes = Mathf.Floor(timeLeft / 60);
        seconds = timeLeft % 60;
        if (seconds > 59) seconds = 59;
        if (minutes < 0)
        {
            stop = true;
            minutes = 0;
            seconds = 0;         
            
        }
        //        fraction = (timeLeft * 100) % 100;
    }

    private IEnumerator updateCoroutine()
    {
        while (!stop)
        {
            text.text = string.Format("{0:0}:{1:00}", minutes, seconds);

            // an algorithem for calculating laps between attack/spawning
            if (Mathf.Floor(timeLeft)% lapsInterval == 0 && Mathf.Floor(timeLeft) != 0)//y
            {
                itsTimeToSpawn = true;
                Debug.Log("TRUE____Sec: "+ seconds + "TL:"+ timeLeft);
                //call for spawning
                
            }
            else
            {
                itsTimeToSpawn = false;
                Debug.Log("false= Sec: " + seconds + "TL:"+ timeLeft);
            }

            if (Mathf.Floor(timeLeft) == 0)
            {
                
                gameOverPanel.SetActive(true);
                player.SetActive(false);
                
            }

            yield return new WaitForSeconds(0.2f);
        }
    }
}
