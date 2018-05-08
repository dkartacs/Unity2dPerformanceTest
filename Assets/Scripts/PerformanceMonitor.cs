using UnityEngine;

public class PerformanceMonitor : MonoBehaviour {

    public int objectCounter = 0;
    public int created = 0;
    public int destroyed = 0;
    private float deltaTime = 0.0f;

    void Start()
    {
        objectCounter = 0;
        Debug.Log("Static me plox: " + GameController.MaxRunTime);
    }

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
    }

    public int GetFps()
    {
        return (int)(1.0f / deltaTime);
    }

    public void Increase()
    {
        objectCounter++;
        created++;
    }

    public void Decrease()
    {
        objectCounter--;
        destroyed++;
    }

    public long GetAllocatedMemoryInBytes()
    {
        return System.GC.GetTotalMemory(false);
    }
}
