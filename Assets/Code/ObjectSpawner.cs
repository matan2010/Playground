using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    //public GameObject objectToSpawn; // The prefab of the object you want to spawn
    //public Vector2 mapSize = new Vector2(10, 10); // Size of the map
    //public Transform player1; // Reference to Player 1
    //public Transform player2; // Reference to Player 2

    public GameObject objectToSpawn;
    public GameObject chasingObjectPrefab;
    public Vector2 mapSize = new Vector2(10, 10);
    //public PlayerScore player1;
    //public PlayerScore player2;
    public float minDistanceFromPlayers = 2f; // Minimum spawn distance from players

    private GameObject spawnedObject;

    void Start()
    {
        SpawnObject();
    }

    public void SpawnObject()
    {
      
    }

    

    public void ScorePoint(int playerNumber)
    {
      //  PlayerScore scoringPlayer = (playerNumber == 1) ? player1 : player2;
      //  scoringPlayer.AddPoint();
        // You could trigger additional game logic or UI updates here
    }
    public void SpawnChasingObject(int playerNumber)
    {
       // PlayerScore targetPlayer = (playerNumber == 1) ? player2 : player1;
        Vector3 spawnPosition = spawnedObject.transform.position;
        GameObject chasingObj = Instantiate(chasingObjectPrefab, spawnPosition, Quaternion.identity);

        //ChasingObject chasingScript = chasingObj.GetComponent<ChasingObject>();
       // if (chasingScript != null)
      //  {
       //     chasingScript.Initialize(targetPlayer.transform, this);
        //}
        //else
        {
            Debug.LogError("ChasingObject script not found on the instantiated object!");
        }

        // Respawn the main object
        SpawnObject();
    }


}

public class ObjectBehavior : MonoBehaviour
{
    public ObjectSpawner spawner;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
        }
    }
}
