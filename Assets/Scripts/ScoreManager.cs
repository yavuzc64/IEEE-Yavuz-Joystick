using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public int Score;
    public TMP_Text ScoreText;
    public TMP_Text FinalText;
    public TMP_Text timer;
    public GameObject FinishPanel;
    [SerializeField] private float time = 80f;

    public static ScoreManager instance;

    public bool isFinish = false;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if (!isFinish)
        {
            time -= Time.deltaTime;

            if (time <= 0f)
            {
                time = 0f;
                isFinish = true;

            }
            if (Score == Coinspawn.instance.spawnPoints.Length)
            {
                isFinish = true;
            }
            countdowntext();
        }
        if (isFinish)
        {
            FinishPanel.SetActive(true);
            if(time > 0f)
            {
                FinalText.text = "You Win";
            }
            else
            {
                FinalText.text = "Gameover";
            }
        }
    }

    private void countdowntext()
    {
        int seconds = Mathf.CeilToInt(time);
        timer.text = "Time: " + seconds;

    }
    public void IncreaseScore(int amount)
    {
        Score += amount;
        ScoreText.text = "Score: " + Score + "/" + Coinspawn.instance.spawnPoints.Length;
    }


}
