using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject target;
    public bool invert = false; // if true, activate target when pressed; else deactivate

    private int objectsOnPlate = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Block"))
        {
            objectsOnPlate++;
            UpdateTarget();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Block"))
        {
            objectsOnPlate--;
            UpdateTarget();
        }
    }

    private void UpdateTarget()
    {
        if (target != null)
        {
            if (invert)
            {
                target.SetActive(objectsOnPlate > 0);
            }
            else
            {
                target.SetActive(objectsOnPlate == 0);
            }
        }
    }
}
