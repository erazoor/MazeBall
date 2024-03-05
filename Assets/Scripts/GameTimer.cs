using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public TMP_Text timerText;
    private float startTime;
    private bool isRunning = true;
    
    void Start()
    {
        startTime = Time.time;
    }
    
    public void StopTimer()
    {
        isRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isRunning) return;
        
        float t = Time.time - startTime;
        string minutes = ((int) t / 60).ToString("00");
        string seconds = (t % 60).ToString("00");
        
        timerText.text = minutes + ":" + seconds;
    }
}
