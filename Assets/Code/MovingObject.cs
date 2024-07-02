using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public Vector2 mapSize = new Vector2(10, 10);
   
    public GameObject movingObjectPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MoveToRandomPosition();
        }
    }

    private void MoveToRandomPosition()
    {
        float randomX = Random.Range(-mapSize.x / 2, mapSize.x / 2);
        float randomY = Random.Range(-mapSize.y / 2, mapSize.y / 2);
        transform.position = new Vector3(randomX, randomY, 0);
    }

    
}
