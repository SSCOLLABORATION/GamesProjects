using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Player ki movement script disable karna
            movement.enabled = false;
            
            // Rigidbody get karke uski speed ko zero karna
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;         // Aage/peeche/upar ki speed zero
                rb.angularVelocity = Vector3.zero;  // Gol ghumne (rotation) ki speed zero
            }
            FindObjectOfType<GameManager>().GameOver(); // GameManager script ko call karna
        }
    }
}