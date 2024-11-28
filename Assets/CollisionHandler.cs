using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            Debug.Log("Picked up: " + other.name);
            Destroy(other.gameObject);
        }
    }
}

