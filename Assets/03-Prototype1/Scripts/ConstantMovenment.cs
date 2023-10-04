using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ConstantMovement : MonoBehaviour
{
    [Tooltip("Constant speed of the ball in the X direction")]
    public float constantSpeedX = 1f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Ensure that the Rigidbody is affected by gravity
        rb.useGravity = true;
    }

    private void FixedUpdate()
    {
        // Set the X component of the velocity to the desired constant speed
        // Retain the Y component from the Rigidbody (so it's affected by gravity)
        // Retain the Z component if you have any other influences on that axis or set to zero if not needed
        Vector3 newVelocity = new Vector3(constantSpeedX, rb.velocity.y, rb.velocity.z);
        rb.velocity = newVelocity;
    }
}
