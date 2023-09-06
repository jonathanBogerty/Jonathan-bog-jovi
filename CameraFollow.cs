using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float cameraSpeed = 10f;

    private void Update()
    {
        Vector3 currentPosition = transform.position;

        float targetY = -5;

        if (player.position.y < -5f)
        {
            targetY = -10f;
        }
        else if (player.position.y > -5f)
        {
            targetY = 0f;
        }

        currentPosition.y = Mathf.Lerp(currentPosition.y, targetY, Time.deltaTime * cameraSpeed);

        transform.position = currentPosition;
    }
}