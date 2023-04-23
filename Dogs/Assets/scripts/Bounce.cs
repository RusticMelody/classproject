using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Transform startPoint;    // Starting point of movement
    public Transform endPoint;      // Ending point of movement
    public float moveSpeed;         // Speed of movement

    private Vector3 currentTarget;  // Current target position

    void Start()
    {
        currentTarget = startPoint.position;   // Set starting position as current target
    }

    void Update()
    {
        // Move object towards current target
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, moveSpeed * Time.deltaTime);

        // If object has reached current target, set next target
        if (transform.position == currentTarget)
        {
            currentTarget = (currentTarget == startPoint.position) ? endPoint.position : startPoint.position;
        }
    }
}
