using UnityEngine;
using UnityEngine.UI;

public class MemoryCounter : MonoBehaviour
{
    public Text objects;
    public PerformanceMonitor performanceMonitor;

    void Start()
    {
        InvokeRepeating("Memory", 0, 0.3f);
    }

    private void Memory()
    {
        objects.text = "" + performanceMonitor.GetAllocatedMemoryInBytes() / 1000000;
    }
}
