using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed = 10.0f;

    private float xLimit = -30.0f; // past the box

    private void Update()
    {
        ThrowBall();
        DestroyOutOfBounds();
    }

    private void ThrowBall()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void DestroyOutOfBounds()
    {
        if (transform.position.x < xLimit)
        {
            Destroy(this.gameObject);
        }
    }
}
