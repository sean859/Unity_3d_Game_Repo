using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;


    void OnTriggerEnter(Collider collider)
    {
        // Once the player collides with this platform it will set its "isFalling" bool to true
        if(collider.gameObject.name == "Player")
        {
            isFalling = true;
            Destroy(gameObject, 2);
        }
    }


    void Update()
    {
        // If "isFalling" is set to true then the platform will begin to set its y axis - the downSpeed you set, till it falls for 2 seconds destroying itself
        if (isFalling)
        {
            downSpeed += Time.deltaTime/30;
            transform.position = new Vector3(transform.position.x,
            transform.position.y-downSpeed,
            transform.position.z);
        }
    }
}
