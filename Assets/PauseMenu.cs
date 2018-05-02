using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public PerformanceMonitor performanceMonitor;
    public GameObject pauseMenu;

    private void Start()
    {
        InvokeRepeating("CheckFps", 3, 0.5f);
    }

    void CheckFps() {
		if(performanceMonitor.GetFps() < 20) {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
	}
}
