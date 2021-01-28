using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject sphere;

    public static float duration = 30.0f;
    private static bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isGameOver)
        {
            Instantiate(sphere);
        }

        StartCoroutine(GameCoroutine()); // game lasts for set amount of time

    }

    private IEnumerator GameCoroutine()
    {
        yield return new WaitForSeconds(duration);

        isGameOver = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Scene");
    }

}
