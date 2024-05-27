using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{

    //Creating new game objects for both the player and the checkpoints

    [SerializeField] GameObject player;

    [SerializeField] List<GameObject> checkPoints;

    [SerializeField] Vector3 vectorPoint;

    [SerializeField] float dead;

    // Update is called once per frame
    void Update()
    {
        // If the player goes below a certain y axis it will reset the player at their last vectorPoint
        if(player.transform.position.y < dead)
        {
            player.transform.position = vectorPoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // If the player collides with a gameobject with the "Coin" tag it will destroy it and set its vectorPoint (spawnpoint) their
        if(other.gameObject.tag == "Coin")
        {
            vectorPoint = player.transform.position;
            Destroy(other.gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        // If the player collides with a object with the "Respawn" tag it will reset the player at their last vectorPoint (basically a trap the player has to avoid)
        if(col.gameObject.tag == "Respawn")
        {
            player.transform.position = vectorPoint;
        }
    }
    
    void OnTriggerEnter(Collision voi)
    {
        // If the player collides with an object with the "Ghost" tag the player will flow right through it almost like a ghost (good for making fake platforms)
        if(voi.gameObject.tag == "Ghost")
        {
            Destroy(voi.gameObject);
        }
    }


}

