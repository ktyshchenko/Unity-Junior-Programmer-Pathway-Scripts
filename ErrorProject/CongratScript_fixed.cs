using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class CongratScript : MonoBehaviour
{
    public TextMesh congratsText;
    public ParticleSystem sparksParticles;

    private List<string> textToDisplay = new List<string>();

    private float rotatingSpeed;
    private float timeToNextText;

    private int currentText;

    // Start is called before the first frame update
    private void Start()
    {
        // Initialize values
        timeToNextText = 0.0f;
        currentText = 0;
        rotatingSpeed = 10.0f;

        // Add text
        textToDisplay.Add("Congratulations!");
        textToDisplay.Add("All Errors Fixed!");

        congratsText.text = textToDisplay[0]; // initial text

        sparksParticles.Play();
    }

    // Update is called once per frame
    private void Update()
    {
        RotateText();
        timeToNextText += Time.deltaTime;

        DisplayText();
    }

    private void RotateText()
    {
        congratsText.transform.Rotate(0f, 0f, rotatingSpeed * Time.deltaTime);
    }

    private void DisplayText()
    {
        if (timeToNextText > 1.5f)
        {
            timeToNextText = 0.0f; // reset

            currentText++;

            if (currentText >= textToDisplay.Count)
            {
                currentText = 0;
            }

            congratsText.text = textToDisplay[currentText];
        }
    }
}