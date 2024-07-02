using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingObject : MonoBehaviour
{
    public float speed = 5f;
    public float lifeTime = 3f;
    public float respawnDelay = 5f;
    public Vector2 respawnArea = new Vector2(10f, 10f); // Size of the respawn area

    private GameObject[] players;
    private Transform target;

    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        target = GetClosestPlayer();
        StartCoroutine(DisappearAfterTime(lifeTime));
    }

    void Update()
    {
        if (target != null)
        {
            Vector2 direction = (target.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    Transform GetClosestPlayer()
    {
        Transform closestPlayer = null;
        float minDistance = Mathf.Infinity;
        foreach (GameObject player in players)
        {
            float distance = Vector2.Distance(transform.position, player.transform.position);
            if (distance < minDistance)
            {
                closestPlayer = player.transform;
                minDistance = distance;
            }
        }
        return closestPlayer;
    }

    IEnumerator DisappearAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        Respawn();
        Destroy(gameObject);
    }

    void Respawn()
    {
        Vector2 randomPosition = new Vector2(Random.Range(-respawnArea.x / 2f, respawnArea.x / 2f),
                                        Random.Range(-respawnArea.y / 2f, respawnArea.y / 2f));
        GameObject newObject = Instantiate(gameObject, randomPosition, Quaternion.identity);
        newObject.name = gameObject.name;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DoNothing();
            Destroy(gameObject); // Optional: destroy the object upon collision
        }
    }

    void DoNothing()
    {
        // This function intentionally left blank
    }
}
