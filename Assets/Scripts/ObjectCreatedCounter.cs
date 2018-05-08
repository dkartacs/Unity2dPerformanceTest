using UnityEngine;
using UnityEngine.UI;

public class ObjectCreatedCounter : MonoBehaviour
{
    public Text objects;
    public PerformanceMonitor performanceMonitor;

    void Start()
    {
        InvokeRepeating("Created", 0, 0.3f);
    }

    private void Created()
    {
        objects.text = "" + performanceMonitor.created;
    }
}
