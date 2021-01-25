using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Slider audioSlider;

    private AudioSource ac;

    private void Start()
    {
        GetAudio();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void AudioVolumeChange()
    {
        if (ac != null)
        {
            ac.volume = audioSlider.value;
        }
    }

    public void GetAudio()
    {
        ac = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        ac.volume = 0.5f;
    }
}
