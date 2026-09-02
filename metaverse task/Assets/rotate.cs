
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 rotationAxis = Vector3.up;
   void Update()
   {
       transform.Rotate(rotationAxis * speed * Time.deltaTime, Space.Self);
   }
   
}
