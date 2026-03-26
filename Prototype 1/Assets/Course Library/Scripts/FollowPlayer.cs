using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Private Variables
    public GameObject player;
    [SerializeField] private Vector3 camera_offset = new Vector3(0f, 6.6f, -9.7f);

    // Update is called once per frame
    void LateUpdate()
    {
        // For following the player with the camera
        transform.position = player.transform.position + camera_offset;
    }
}
