using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private float limit = 3.0f; // limit to set position/scale

    void Start()
    {
        SetPosition();
        SetScale();
    }
    
    void Update()
    {

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
}
