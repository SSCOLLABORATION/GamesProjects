
using UnityEngine;
using UnityEngine.SceneManagement; // SceneManager ko use karne ke liye zaroori hai

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
        Debug.Log("Game Over");
    }

    void Restart()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Current scene ko reload karna

    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);

    }


}
