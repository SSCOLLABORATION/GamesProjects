using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            gameManager.CompleteLevel();
        }
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if(rb != null)
        {
            rb.velocity = Vector3.zero;         // Aage/peeche/upar ki speed zero
            rb.angularVelocity = Vector3.zero;  // Gol ghumne (rotation) ki speed zero
        }
        PlayerMovement movement = other.GetComponent<PlayerMovement>();
        if (movement != null)
        {
            movement.enabled = false; // Player ki movement script disable karna
        }
    }
    // Start is called before the first frame update
}
