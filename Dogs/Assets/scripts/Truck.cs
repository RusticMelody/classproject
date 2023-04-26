using UnityEngine;

public class Truck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Old") && transform.CompareTag("Truck"))
        {
            Destroy(collision.gameObject);
        }
    }
}