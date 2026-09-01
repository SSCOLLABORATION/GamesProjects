
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float ForwardForce = 0f;
    public float SidewaysForce = 0f;

    void Start()
    {
        
        
    }

    
    void FixedUpdate()
    {
        //Add forward Force
        if(Input.GetKey("w"))
        {
        rb.AddForce(0, 0,ForwardForce*Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0,-ForwardForce*Time.deltaTime, ForceMode.VelocityChange);
        }

        if(Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
