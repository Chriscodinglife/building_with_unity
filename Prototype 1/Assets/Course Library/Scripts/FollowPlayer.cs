using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Private Variables
    public GameObject player;
    private Vector3 camera_offset = new Vector3(0f, 6.6f, -9.7f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // For following the player with the camera
        transform.position = player.transform.position + camera_offset;
    }
}
