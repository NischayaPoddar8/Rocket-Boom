using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public HealthBar healthBar;
    public AudioSource BackgroundAudio;
    public AudioSource GameOverAudio;
    public GameObject gameOver;

    int maxHealth = 100;
    bool isGameOver = false;

    void Start()
    {
        healthBar.setHealth(maxHealth);
    }

    void Update()
    {
        if(healthBar.slider.value <= 0 && !isGameOver)
        {   
            isGameOver = true;
            if(BackgroundAudio.isPlaying) BackgroundAudio.Pause();
            Time.timeScale = 0f;
            gameOver.SetActive(true);
            GameOverAudio.Play();
            Debug.Log("Game Over!");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            decreaseHealth();
            Debug.Log("Collision with obstacle");
        }
    }

    void decreaseHealth()
    {
        healthBar.slider.value -= 20;
    }
}
