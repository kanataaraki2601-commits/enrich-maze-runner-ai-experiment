using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Laser : MonoBehaviour
{
    public int reflections = 5;
    public float maxLength = 100f;

    private LineRenderer lr;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        DrawLaser();
    }

    private void DrawLaser()
    {
        Vector3 direction = transform.right;
        Vector3 position = transform.position;

        lr.positionCount = 1;
        lr.SetPosition(0, position);

        for (int i = 0; i < reflections; i++)
        {
            RaycastHit2D hit = Physics2D.Raycast(position, direction, maxLength);
            if (hit.collider != null)
            {
                lr.positionCount++;
                lr.SetPosition(lr.positionCount - 1, hit.point);

                if (hit.collider.CompareTag("Mirror"))
                {
                    direction = Vector2.Reflect(direction, hit.normal);
                    position = hit.point + (Vector2)direction * 0.01f;
                    continue;
                }
                else
                {
                    break;
                }
            }
            else
            {
                lr.positionCount++;
                lr.SetPosition(lr.positionCount - 1, position + (Vector3)direction * maxLength);
                break;
            }
        }
    }
}
