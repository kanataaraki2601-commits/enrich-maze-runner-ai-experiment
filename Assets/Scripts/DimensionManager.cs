using UnityEngine;

public class DimensionManager : MonoBehaviour
{
    public GameObject dimensionA;
    public GameObject dimensionB;
    private bool inDimensionA = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inDimensionA = !inDimensionA;
            dimensionA.SetActive(inDimensionA);
            dimensionB.SetActive(!inDimensionA);
        }
    }
}
