using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    private void Update()
    {
        Vector3 currentPosition = transform.position;

        if (currentPosition.x > 10f)
        {
            transform.position = new Vector3(-10f, currentPosition.y, currentPosition.z);
        }
        else if (currentPosition.x < -10f)
        {
            transform.position = new Vector3(10f, currentPosition.y, currentPosition.z);
        }
    }
}
