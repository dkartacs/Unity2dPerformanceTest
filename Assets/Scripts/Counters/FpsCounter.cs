using UnityEngine;
using UnityEngine.UI;

public class FpsCounter : MonoBehaviour {

    public Text fps;
    public PerformanceMonitor performanceMonitor;

	void Start () {
        InvokeRepeating("Fps", 0, 0.3f);
    }
	
	private void Fps() {
        fps.text = "" + performanceMonitor.GetFps();
    }
}
