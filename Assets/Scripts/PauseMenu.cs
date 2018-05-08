using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public PerformanceMonitor performanceMonitor;
    public GameObject pauseMenu;

    private void Start()
    {
        //There is some wierd unity shit, and the timescale does not reset all the time (only "sometimes"...) on scene load with all the other variables
        Time.timeScale = 1f;
        InvokeRepeating("CheckFps", 3, 0.5f);
        Invoke("TimeOut", GameController.MaxRunTime);
    }

    void CheckFps() {
		if(performanceMonitor.GetFps() < GameController.MinFps) {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
	}

    void TimeOut()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PreviousScene()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    public void NextScene()
    {
        if (SceneManager.sceneCountInBuildSettings - 1 > SceneManager.GetActiveScene().buildIndex) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
