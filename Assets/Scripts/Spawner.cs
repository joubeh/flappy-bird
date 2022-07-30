using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PipesPrefab;
    public float spwanSpeed;
    public float minH = -1;
    public float maxH = 1;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spwanSpeed, spwanSpeed);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(PipesPrefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minH, maxH);
    }
}
