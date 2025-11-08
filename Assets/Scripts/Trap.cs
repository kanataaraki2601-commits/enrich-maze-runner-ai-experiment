using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Restart current scene if player touches trap
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
