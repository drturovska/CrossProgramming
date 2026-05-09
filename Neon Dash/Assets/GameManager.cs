using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameEnded = false;

    public void GameOver()
    {
        if (gameEnded == false)
        {
            gameEnded = true;

            Debug.Log("GAME OVER");

            Invoke("Restart", 1f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}