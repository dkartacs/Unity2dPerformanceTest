using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

    public void StartTest()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void SetMaxRunTime(float maxRunTime)
    {
        GameController.MaxRunTime = maxRunTime;
    }

    public void SetMinFps(float minFps)
    {
        GameController.MinFps = minFps;
    }
}
