using UnityEngine;

public class Mirror : MonoBehaviour
{
    public float rotationSpeed = 90f; // degrees per second

    void Update()
    {
        // rotate mirror with Q/E keys
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
        }
    }
}
