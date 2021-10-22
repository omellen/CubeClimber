using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhenPlayAgainClicked : MonoBehaviour
{
    public Transform player;
    void Start()
    {

    }

    public void Clicked()
    {
        player.SetPositionAndRotation(new Vector3(4f, 5.25f, -1.25f), new Quaternion(0, 0, 0, 0));
 
    }
   
}
