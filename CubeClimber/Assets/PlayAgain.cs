using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgain : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        player.SetPositionAndRotation(new Vector3(4f, 5.25f, -1.25f), new Quaternion(0, 0, 0, 0));
    }

    
}
