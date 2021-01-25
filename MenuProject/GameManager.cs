using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private GameObject[] mainComponents;
    private GameObject[] optionsComponents;
    private TMP_Text[] textComponents;
    private Text[] textComponents2;
    private GameObject[] all;

    public Slider textSizeSlider;
    public Dropdown textColorDropdown;
    public Toggle modeToggle;
    public Slider audioSlider;

    [SerializeField]
    private bool isLightMode = true;

    private AudioSource ac;

    private void Start()
    {
        textComponents = Object.FindObjectsOfType<TMP_Text>();
        textComponents2 = Object.FindObjectsOfType<Text>();

        all = GameObject.FindObjectsOfType<GameObject>();

        optionsComponents = GameObject.FindGameObjectsWithTag("OptionsMenu");
        foreach (GameObject obj in optionsComponents)
        {
            obj.SetActive(false);
        }

        mainComponents = GameObject.FindGameObjectsWithTag("MainMenu");

        GetAudio();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OptionsOn()
    {
        foreach (GameObject obj in optionsComponents)
        {
            obj.SetActive(true);
        }

        foreach (GameObject obj in mainComponents)
        {
            obj.SetActive(false);
        }
    }

    public void OptionsOff()
    {
        foreach (GameObject obj in optionsComponents)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in mainComponents)
        {
            obj.SetActive(true);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Application exited");
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

    public void ModeChange()
    {
        if (modeToggle.isOn)
        {
            isLightMode = true;
            foreach (GameObject one in all)
            {
                if (one.GetComponent<Image>() != null)
                {
                    one.GetComponent<Image>().color = Color.white;
                    if (one.name == "Panel")
                    {
                        var panelColor = one.GetComponent<Image>().color;
                        panelColor.a = 0.2f;
                        one.GetComponent<Image>().color = panelColor;
                    }
                }
            }

            foreach (TMP_Text texts in textComponents)
            {
                texts.color = Color.black;
            }

            foreach (Text texts in textComponents2)
            {
                texts.color = Color.black;
            }

            textColorDropdown.value = 5;
        }
        else
        {
            isLightMode = false;
            foreach (GameObject one in all)
            {
                if (one.GetComponent<Image>() != null)
                {
                    print(one.name);
                    one.GetComponent<Image>().color = Color.black;
                    if (one.name == "Panel")
                    {
                        var panelColor = one.GetComponent<Image>().color;
                        panelColor.a = 0.2f;
                        one.GetComponent<Image>().color = panelColor;
                    }
                }
            }

            foreach (TMP_Text texts in textComponents)
            {
                texts.color = Color.white;
            }

            foreach (Text texts in textComponents2)
            {
                texts.color = Color.white;
            }

            textColorDropdown.value = 5;
        }
    }

    public void GetAudio()
    {
        ac = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        ac.volume = 0.5f;
    }
}
