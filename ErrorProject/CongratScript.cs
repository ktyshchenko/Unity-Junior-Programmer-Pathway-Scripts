using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class CongratScript : MonoBehaviour
{
    public TextMesh text;
    public ParticleSystem sparksParticles;

    private List<string> textToDisplay = new List<string>();

    private float rotatingSpeed;
    private float timeToNextText;

    private int currentText;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize values
        timeToNextText = 0.0f;
        currentText = 0;
        rotatingSpeed = 10.0f;

        textToDisplay.Add("Congratulation");
        textToDisplay.Add("All Errors Fixed");

        text.text = textToDisplay[0];

        sparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        text.transform.Rotate(0f, 0f, rotatingSpeed * Time.deltaTime);
        timeToNextText += Time.deltaTime;

        if (timeToNextText > 1.5f)
        {
            timeToNextText = 0.0f;

            currentText++;

            if (currentText >= textToDisplay.Count)
            {
                currentText = 0;
            }

            text.text = textToDisplay[currentText];
        }
    }
}