using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public float spawnHeight = 5f;
    public float minY = 1f;
    public float maxY = 3f;

    private float lastSpawnY;

    private void Start()
    {
        lastSpawnY = transform.position.y;

        // Initial platforms
        for (int i = 0; i < 10; i++)
        {
            SpawnPlatform();
        }
    }

    private void Update()
    {
        if (Camera.main.transform.position.y + spawnHeight > lastSpawnY)
        {
            SpawnPlatform();
        }
    }

    private void SpawnPlatform()
    {
        float x = Random.Range(-8f, 8f);
        float y = Random.Range(minY, maxY);

        Vector2 spawnPosition = new Vector2(x, lastSpawnY + y);
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

        lastSpawnY += y;
    }
}
