using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public float xMin, xMax, yMin, yMax; // Define the boundaries for random spawn positions
    public GameObject objectToSpawn;
    void Start()
    {
        objectToSpawn.transform.position= GetRandomPosition();
        MoveToRandomPosition();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MoveToRandomPosition();
        }
    }

    void MoveToRandomPosition()
    {
        float randomX = Random.Range(xMin, xMax);
        float randomY = Random.Range(yMin, yMax);
        transform.position = new Vector2(randomX, randomY);
    }

    Vector3 GetRandomPosition()
    {
        float randomX = Random.Range(xMin, xMax);
        float randomY = Random.Range(yMin / 2, yMax);
        return new Vector3(randomX, randomY, 0);
    }
}
