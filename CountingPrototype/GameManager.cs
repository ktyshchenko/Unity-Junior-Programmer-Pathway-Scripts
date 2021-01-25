using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject sphere;

    private static float duration = 30.0f;
    private static bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isGameOver)
        {
            Instantiate(sphere);
        }

        StartCoroutine(GameCoroutine());

    }

    private IEnumerator GameCoroutine()
    {
        yield return new WaitForSeconds(duration);

        isGameOver = true;
    }


}
