using UnityEngine;
using UnityEngine.SceneManagement; // for restarting the game

public class FishController : MonoBehaviour
{
    public float flapStrength = 5f; // upward force when flapping
    private Rigidbody2D rb;
    private bool isAlive = true;
    public GameObject panel;


    void Start()
    {
         Time.timeScale = 1f; 
        rb = GetComponent<Rigidbody2D>();
        panel.SetActive(false);
    }

    void Update()
    {
        if (!isAlive) return;

        // Flap on space key or screen tap
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * flapStrength;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if we passed through the score zone
        if (collision.CompareTag("ScoreZone"))
        {
            ScoreManager.instance.AddScore();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Stop game on collision with obstacle or ground
        Debug.Log("Game Over!");
        isAlive = false;
        panel.SetActive(true);
        Time.timeScale = 0; // pause game
    }
}
