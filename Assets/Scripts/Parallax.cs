using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer m_Renderer;
    public float speed = 0.1f;

    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
    }
    
    void Update()
    {
        m_Renderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);    
    }
}
