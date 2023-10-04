using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5.0f; // Adjust as needed
    private bool isGrounded = true; // Assumes the ball starts on the ground
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Jump();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check for ground to allow jumping again
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        // Check collision with the block to restart the game
        if (collision.gameObject.CompareTag("Block"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
