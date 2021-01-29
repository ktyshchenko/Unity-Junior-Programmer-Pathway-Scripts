using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSideways : MonoBehaviour
{
    public static int zLimit = 10; // set area where box can move
    public bool isGoingLeft = false;

    private Vector3 direction;
    private float movementSpeed = 8.0f;

    private void Update()
    {
        MoveBox();
    }

    private void MoveBox()
    {
        if (transform.position.z <= zLimit && isGoingLeft == false)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        else if (transform.position.z >= -zLimit && isGoingLeft == true)
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
        }
        
        if (transform.position.z >= zLimit)
        {
            isGoingLeft = true;
        }

        if (transform.position.z <= -zLimit)
        {
            isGoingLeft = false;
        }
    }
}
