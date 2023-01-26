using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartScene : MonoBehaviour
{

     void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {                
            SceneManager.LoadScene("StartScene"); // loads start scene
        } 
    }
}
