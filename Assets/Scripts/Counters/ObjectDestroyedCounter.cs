using UnityEngine;
using UnityEngine.UI;

public class ObjectDestroyedCounter : MonoBehaviour
{
    public Text objects;
    public PerformanceMonitor performanceMonitor;

    void Start()
    {
        InvokeRepeating("Destroyed", 0, 0.3f);
    }

    private void Destroyed()
    {
        objects.text = "" + performanceMonitor.destroyed;
    }
}
