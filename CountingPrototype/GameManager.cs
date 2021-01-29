using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject player;

    public static float duration = 30.0f;
    private static bool isGameOver = false;

    public GameObject gameOverText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isGameOver)
        {
            Instantiate(ball, player.transform); // ball appears where player is
        }

        StartCoroutine(GameCoroutine()); // game lasts for set amount of time
        GameOver();

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

    private void GameOver()
    {
        if (isGameOver == true)
        {
            gameOverText.SetActive(true);
        }
    }

}
