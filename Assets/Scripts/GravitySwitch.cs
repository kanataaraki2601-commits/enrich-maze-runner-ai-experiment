using UnityEngine;

public class GravitySwitch : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool isGravityInverted = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            isGravityInverted = !isGravityInverted;
            FlipGravity();
        }
    }

    void FlipGravity()
    {
        if (rb != null)
        {
            rb.gravityScale *= -1;
            // Flip player vertically for visual orientation
            Vector3 scale = transform.localScale;
            scale.y *= -1;
            transform.localScale = scale;
        }
    }
}
