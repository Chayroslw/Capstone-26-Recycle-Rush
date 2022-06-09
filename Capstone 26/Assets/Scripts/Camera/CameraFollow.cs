using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    [Range(1, 10)]
    public float smoothFactor = 1f;

    private void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }
}
