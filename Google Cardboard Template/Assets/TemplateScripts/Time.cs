using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    public float timeLeft = 60f;
    public Text timeDisplay;


    // Start is called before the first frame update
    void Start()
    {
        timeDisplay.text = "Time Remaining: " + timeLeft.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0)
        {
           // timeLeft -= Time.deltaTime;

        }
    }

    public void changeText(int count)
    {
        this.timeLeft -= count;
        this.timeDisplay.text = "Time Remaining: " + timeLeft.ToString();
    }
}
