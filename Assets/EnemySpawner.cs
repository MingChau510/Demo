using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 1.5f;   // thời gian giữa mỗi enemy
    public float minX = -2.5f;
    public float maxX = 2.5f;
    public float spawnY = 6f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnRate);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(minX, maxX);
        Vector2 spawnPos = new Vector2(randomX, spawnY);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}