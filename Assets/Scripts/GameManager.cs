using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public float restartDelay;
    public GameObject completeLevelUI;
        
    public void CompleteLevel()
    {
        Debug.Log("Level Complete");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameOver == false)
        {
            gameOver = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        //SceneManager.LoadScene("Nivel01");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
