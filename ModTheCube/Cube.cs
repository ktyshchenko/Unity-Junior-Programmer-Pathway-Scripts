using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        SetPosition();
    }
    
    void Update()
    {

    }

    private void SetPosition()
    {
        Vector3 pos = new Vector3(Random.Range(0f, limit), limit * 2, 0.0f);
        transform.position = pos;
    }
}
