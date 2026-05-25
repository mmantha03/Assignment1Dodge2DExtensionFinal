using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab;

    public float spawnInterval = 1f;

    public float minSize = 0.5f;
    public float maxSize = 1.8f;

    float timer = 0f;

    void SpawnFallingObject()
    {
        float xPos = Random.Range(-8f, 8f);
        Vector3 spawnPos = new Vector3(xPos, transform.position.y, 0f);

        GameObject newObject = Instantiate(fallingObjectPrefab, spawnPos, Quaternion.identity);

        // this is for the random object size
        float randomSize = Random.Range(minSize, maxSize);
        newObject.transform.localScale = new Vector3(randomSize, randomSize, 1f);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnFallingObject();
            timer = 0f;
        }
    }
}