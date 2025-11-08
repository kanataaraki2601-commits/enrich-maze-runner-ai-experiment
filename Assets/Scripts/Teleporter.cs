using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform destination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && destination != null)
        {
            collision.transform.position = destination.position;
        }
    }
}
