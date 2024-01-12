using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    public float smoothTime = 0.25f;
    public float thing;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private GameObject target;
    [SerializeField] private GameObject player;

    private void FixedUpdate()
    {
        target.transform.position = player.transform.position + new Vector3((player.GetComponent<Rigidbody2D>().velocity.x) * thing, (player.GetComponent<Rigidbody2D>().velocity.y) * thing, -10f);
        Vector3 targetPosition = target.transform.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}