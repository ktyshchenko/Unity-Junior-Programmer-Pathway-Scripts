using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private TMP_Text[] textComponents;
    private Text[] textComponents2;
    public Slider audioSlider;

    public Slider textSizeSlider;
    public Dropdown textColorDropdown;
    private AudioSource ac;

    private void Start()
    {
        textComponents = Object.FindObjectsOfType<TMP_Text>();
        textComponents2 = Object.FindObjectsOfType<Text>();

        GetAudio();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void TextSizeChange()
    {
        foreach (TMP_Text texts in textComponents)
        {
            texts.fontSize = (int)textSizeSlider.value;
        }

        foreach (Text texts in textComponents2)
        {
            texts.fontSize = (int)textSizeSlider.value;
        }
    }

    public void TextColorChange()
    {
        foreach (TMP_Text texts in textComponents)
        {
            switch (textColorDropdown.value)
            {
                case 0:
                    texts.color = Color.blue;
                    break;
                case 1:
                    texts.color = Color.red;
                    break;
                case 2:
                    texts.color = Color.green;
                    break;
                case 3:
                    texts.color = Color.black;
                    break;
                case 4:
                    texts.color = Color.white;
                    break;
                case 5:
                    if (isLightMode)
                    {
                        texts.color = Color.black;
                    }
                    else
                    {
                        texts.color = Color.white;
                    }
                    break;
                default:
                    break;
            }
        }

        foreach (Text texts in textComponents2)
        {
            switch (textColorDropdown.value)
            {
                case 0:
                    texts.color = Color.blue;
                    break;
                case 1:
                    texts.color = Color.red;
                    break;
                case 2:
                    texts.color = Color.green;
                    break;
                case 3:
                    texts.color = Color.black;
                    break;
                case 4:
                    texts.color = Color.white;
                    break;
                case 5:
                    if (isLightMode)
                    {
                        texts.color = Color.black;
                    }
                    else
                    {
                        texts.color = Color.white;
                    }
                    break;
                default:
                    break;
            }
        }
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
