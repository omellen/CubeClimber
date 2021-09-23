using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigid;
    public bool cubeOnGround = true;

    private void FixedUpdate()
    {

        if (Input.GetKey("d"))
        {
            rigid.AddForce(500f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rigid.AddForce(-500f * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("w") && cubeOnGround == true)
        {
            rigid.AddForce(new Vector3(0, 600f * Time.deltaTime, 0), ForceMode.Impulse);
            cubeOnGround = false;
        }

  
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            cubeOnGround = true;
        }
    }

}
