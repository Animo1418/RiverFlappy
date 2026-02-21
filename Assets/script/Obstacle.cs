using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float leftBound = -10f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
