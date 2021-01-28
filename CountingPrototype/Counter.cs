using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;
    public Text timeText;

    private float timeLeft;
    private static float offset = 1.0f; // to make it start at X sec

    private int count = 0;

    private void Start()
    {
        // Initialize
        count = 0;
        timeLeft = GameManager.duration + offset;

        DisplayTime();
    }

    private void Update()
    {
        timeLeft -= Time.deltaTime;
        DisplayTime();
    }

    private void OnTriggerEnter(Collider other)
    {
        count += 1;
        counterText.text = "Count : " + count;
        Destroy(other.gameObject);
    }

    private void DisplayTime()
    {
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }

        timeText.text = "Time : " + (int)timeLeft;
    }
}
