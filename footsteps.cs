using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class footsteps : MonoBehaviour

{

    public AudioSource footstepsSound, sprintSound;



    void Update()

    {
        // Whenever you press WASD, it will set the footstep sound effect to active, and when you stop pressing WASD it will set the sound effect to non-active
        // Unless your pressing WASD and sprint (holding left shift), then it will play a different sound effect (sprinting sound effect), and will also set that to non-active when you realease the keys

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){

            if (Input.GetKey(KeyCode.LeftShift))

            {

                footstepsSound.enabled = false;

                sprintSound.enabled = true;

            }

            else

            {

                footstepsSound.enabled = true;

                sprintSound.enabled = false;

            }

        }

        else

        {

            footstepsSound.enabled = false;

            sprintSound.enabled = false;

        }

        

    }

}