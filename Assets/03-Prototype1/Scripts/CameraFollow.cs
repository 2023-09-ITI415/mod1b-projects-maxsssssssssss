using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target (ball) that the camera should follow
    public float smoothSpeed = 0.125f; // Adjust for camera follow speed (set to 1 for no smoothing)

    private void FixedUpdate()
    {
        if (target)
        {
            Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
