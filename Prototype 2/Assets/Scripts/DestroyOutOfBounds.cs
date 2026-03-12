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
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
    }
}
