using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    [SerializeField] private float speed = 18.0f;
    [SerializeField] private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
    private Vector3 acceleration;

    // Update is called once per frame
    void FixedUpdate()
    {
        // For capturing player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We will move the vehicle forward
        acceleration = Vector3.forward * Time.deltaTime * speed * forwardInput;
        transform.Translate(acceleration);
        
        // If the vehicle has any acceleration then we can turn
        if (acceleration != Vector3.zero) {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        }
        
    }
}
