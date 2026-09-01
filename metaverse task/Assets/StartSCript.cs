using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSCript : MonoBehaviour
{
    // Start is called before the first frame update
 public void StartGame()
    {
        // Load the next scene or start the game logic here
        Debug.Log("Game Started!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
