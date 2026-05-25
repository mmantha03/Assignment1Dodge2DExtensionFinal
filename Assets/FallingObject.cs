using UnityEngine;

public class FallingObject : MonoBehaviour
{
    float fallSpeed = 5f;
    float destroyY = -5f;

    void Update()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

        if (transform.position.y < destroyY)
        {
            Destroy(gameObject);
        }
    }
}