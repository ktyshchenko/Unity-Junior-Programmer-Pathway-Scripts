using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public float speed = 15.0f;
    private float limit = 3.0f; // limit to set position/scale
    private float repeatTime = 2.0f;

    void Start()
    {
        SetPosition();
        SetScale();

        InvokeRepeating("SetColorCube", 0.0f, repeatTime); // change color every X sec
    }
    
    void Update()
    {
        RotateCube();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetPosition();
            SetScale();
        }
    }

    private void SetPosition()
    {
        Vector3 pos = new Vector3(Random.Range(0f, limit), limit * 2, 0.0f);
        transform.position = pos;
    }

    private void SetScale()
    {
        transform.localScale = Vector3.one * Random.Range(0.0f, limit);
    }

    private void SetColorCube()
    {
        Color col = new Color(Random.value, Random.value, Random.value, Random.value);

        Material material = Renderer.material;
        material.color = col;
    }

    private void RotateCube()
    {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, 0.0f); // x, y, z
    }
}
