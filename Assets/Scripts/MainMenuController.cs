using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    [SerializeField] private GameObject play;
    [SerializeField] private GameObject stop;
    [SerializeField] private GameObject pausebutton;
    public void restart()
    {
        SceneManager.LoadScene("Game");   
    }
    public void pauseGame()
    {
        Time.timeScale = 0f;
        play.SetActive(true);
        stop.SetActive(true);
        pausebutton.SetActive(false);
    }

    public void exitGame()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
    public void resumeGame()
    {
        Time.timeScale = 1f;
        play.SetActive(false);
        stop.SetActive(false);
        pausebutton.SetActive(true);
        //Utils.ForceCrash(ForcedCrashCategory.Abort);
    }
}
