using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    PlayerMovement player;
    public void LoadNextLevel()
    {
        player = FindObjectOfType<PlayerMovement>();
        if (player.enabled == true) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }        
    }
}
