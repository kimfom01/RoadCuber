using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game over");
            Invoke(nameof(Restart), restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
