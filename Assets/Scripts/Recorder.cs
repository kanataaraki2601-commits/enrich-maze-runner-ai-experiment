using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour
{
    public GameObject ghostPrefab; // Prefab for the ghost clone
    public float recordInterval = 0.1f;

    private bool isRecording = false;
    private List<Vector3> recordedPositions = new List<Vector3>();
    private float recordTimer;

    void Update()
    {
        // Start recording when R is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            isRecording = true;
            recordedPositions.Clear();
            recordTimer = 0f;
        }
        // Stop recording when T is pressed
        if (Input.GetKeyDown(KeyCode.T))
        {
            isRecording = false;
        }
        // Play back recording when P is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (recordedPositions.Count > 0 && ghostPrefab != null)
            {
                GameObject ghost = Instantiate(ghostPrefab, recordedPositions[0], Quaternion.identity);
                StartCoroutine(PlayRecording(ghost));
            }
        }

        // Record positions at intervals while recording
        if (isRecording)
        {
            recordTimer += Time.deltaTime;
            if (recordTimer >= recordInterval)
            {
                recordTimer = 0f;
                recordedPositions.Add(transform.position);
            }
        }
    }

    private IEnumerator PlayRecording(GameObject ghost)
    {
        foreach (Vector3 pos in recordedPositions)
        {
            ghost.transform.position = pos;
            yield return new WaitForSeconds(recordInterval);
        }
        Destroy(ghost);
    }
}
