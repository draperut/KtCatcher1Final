using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaindropSpawner : MonoBehaviour
{
    public GameObject raindropPrefab; 
    public float spawnRate = 0.1f;
    public float spawnWidth = 20f;

    private float timer;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
       timer += Time.deltaTime;

       if (timer >= spawnRate)
        {
            SpawnRaindrop();
            timer = 0f;
        }
    }
    void SpawnRaindrop()
    {
        float randomX = Random.Range(-spawnWidth / 2f, spawnWidth / 2f);

        Vector3 spawnPosition = new Vector3(transform.position.x + randomX, transform.position.y, 0f);

        Instantiate(raindropPrefab, spawnPosition, Quaternion.identity);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Vector3 lineStart = new Vector3(transform.position.x - (spawnWidth / 2f), transform.position.y, 0f);
        Vector3 lineEnd = new Vector3(transform.position.x - (spawnWidth / 2f), transform.position.y, 0f);
        Gizmos.DrawLine(lineStart, lineEnd);
    }
}
