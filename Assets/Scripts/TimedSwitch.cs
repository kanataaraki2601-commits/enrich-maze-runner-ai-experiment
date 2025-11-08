using UnityEngine;
using System.Collections;

public class TimedSwitch : MonoBehaviour
{
    public GameObject target; // Object to toggle (e.g., door)
    public float duration = 3f; // How long the target stays deactivated
    private bool isTriggered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isTriggered && collision.CompareTag("Player"))
        {
            StartCoroutine(ActivateSwitch());
        }
    }

    private IEnumerator ActivateSwitch()
    {
        isTriggered = true;
        if (target != null)
        {
            target.SetActive(false); // deactivate (e.g. open door)
            yield return new WaitForSeconds(duration);
            target.SetActive(true); // re-enable (close door)
        }
        isTriggered = false;
    }
}
