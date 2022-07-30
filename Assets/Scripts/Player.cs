using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 dir;
    public float gravity = -9.8f;
    public float speed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dir = Vector3.up * speed;
        }

        if(Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if(t.phase == TouchPhase.Began)
            {
                dir = Vector3.up * speed;
            }
        }

        dir.y += gravity * Time.deltaTime;
        transform.position += dir * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bounes")
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().IncreaseScore();
        } else if (collision.tag == "object")
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().GameOver();
        }
    }

    private void OnEnable()
    {
        Vector3 p = transform.position;
        p.y = 0f;
        transform.position = p;
        dir = Vector3.zero;
    }
}
