using UnityEngine;

public class Camera : MonoBehaviour
{
    //Variables
    public Transform player;

    public float smooth = 0.3f;
    public float height;

    private Vector3 velocity = Vector3.zero;

    //Methods
    private void Update()
    {
        Vector3 pos = new Vector3
        {
            x = player.position.x,
            z = player.position.z - 7f,
            y = player.position.y + height
        };
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smooth);
    }
}