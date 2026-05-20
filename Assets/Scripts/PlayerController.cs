using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // This script is used to control the player's vehicle in the game. It allows the player to move forward and turn left or right based on input from the keyboard
    private float speed = 20.0f;
    private float turnSpeed = 85.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the player's input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Make the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Make the vehicle turn left and right
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
