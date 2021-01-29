using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float horizontalInput;
    private Vector3 direction;
    private float movementSpeed = 10.0f;

    private void Update()
    {
        FollowBox();
        OutOfBounds();
    }

    private void FollowBox()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        direction = new Vector3(0.0f, 0.0f, horizontalInput);

        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }

    private void OutOfBounds()
    {
        if (transform.position.z > MoveSideways.zLimit)
        {
            transform.position = new Vector3(0.0f, 0.0f, MoveSideways.zLimit);
        }
        else if (transform.position.z < -MoveSideways.zLimit)
        {
            transform.position = new Vector3(0.0f, 0.0f, -MoveSideways.zLimit);
        }
    }
}

