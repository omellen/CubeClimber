using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endscreen : MonoBehaviour
{
    public Transform player;

    public void Start()
    {
        
    }
    public void GameOver ()
    {	
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
