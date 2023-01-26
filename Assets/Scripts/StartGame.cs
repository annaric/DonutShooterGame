using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartGame : MonoBehaviour
{
    public void StartDonutGame() {
        SceneManager.LoadScene("GameScene"); // loads current scene
    }
}
