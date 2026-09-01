
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    public Transform Player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;
    }
}
