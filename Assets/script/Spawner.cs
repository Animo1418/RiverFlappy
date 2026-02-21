using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 2f;
    public float minY = -1f;
    public float maxY = 3f;

    private float timer;

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            float randomY = Random.Range(minY, maxY);
            Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);
            Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
            timer = 0;
        }
    }
}
