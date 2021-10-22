using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigid;
    public bool cubeOnGround = true;
    public GameObject endScreen;
    public GameObject fireworks;
    public Transform player;

    private void FixedUpdate()
    {
        //movement
        if (Input.GetKey("d"))
        {
            rigid.AddForce(500f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rigid.AddForce(-500f * Time.deltaTime, 0, 0);
        }

        //jump mechanism
        if(Input.GetKey("w") && cubeOnGround == true)
        {
            rigid.AddForce(new Vector3(0, 500f * Time.deltaTime, 0), ForceMode.Impulse);
            cubeOnGround = false;
        }

        //player restart when dies
        if(player.position.y <= 0)
        {
            player.SetPositionAndRotation(new Vector3(4f, 5.25f, -1.25f), new Quaternion(0, 0, 0, 0));
        }
  
    }
    //hits platform
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            cubeOnGround = true;
        }

	    if(collision.gameObject.name == "PlatformFinal")
	    {
	        endScreen.gameObject.SetActive(true);
            fireworks.gameObject.SetActive(true);
	    }
    }

}
