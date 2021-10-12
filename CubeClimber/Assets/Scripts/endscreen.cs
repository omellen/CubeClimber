using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endscreen : MonoBehaviour
{
    public Transform player;

    public void Start()
    {
        PlayAgain();
    }
    public void GameOver ()
    {	
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayAgain()
    {
        player.SetPositionAndRotation(new Vector3(4f, 5.25f, -1.25f), new Quaternion(0, 0, 0,0)); 
    }
}
