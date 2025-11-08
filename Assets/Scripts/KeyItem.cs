using UnityEngine;

public class KeyItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.hasKey = true;
            Destroy(gameObject);
        }
    }
}
