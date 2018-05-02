using UnityEngine;
using UnityEngine.UI;

public class ObjectCounter : MonoBehaviour {

    public Text objects;
    public PerformanceMonitor performanceMonitor;

    void Start() {
        InvokeRepeating("Objects", 0, 0.3f);
    }

    private void Objects () {
        objects.text = "" + performanceMonitor.objectCounter;
	}
}
