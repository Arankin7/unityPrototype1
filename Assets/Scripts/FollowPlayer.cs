using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variable to hold the player game object.  
    public GameObject player;

    private Vector3 camOffset = new Vector3(0, 8, -12); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Gets the current 'transform' component (the camera in this scenario)
        // offsets the camera's position using a new Vector3
        transform.position = player.transform.position + camOffset;
    }
}
