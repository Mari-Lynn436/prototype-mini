using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Create a refference to the player
    public GameObject Cube;

    // Create a variable for the camera's offset/position
    private Vector3 offset = new Vector3(0, 2, -5);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Late update fixes the camera. Without it, the camera will be underneath the car.
    void LateUpdate()
    {
        transform.position = Cube.transform.position + offset;
    }
}

