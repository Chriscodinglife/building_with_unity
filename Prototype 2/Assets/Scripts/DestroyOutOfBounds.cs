using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBounds = 30.0f;
    private float lowerBounds = -10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes out of bounds out of the top of the screen, destroy it
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBounds)
        // Other wise if an object goes out of bounds in the lower part of the screen, destroy it too
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
