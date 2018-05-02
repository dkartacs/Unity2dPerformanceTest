using UnityEngine;

public class PerformanceMonitor : MonoBehaviour {

    public int objectCounter = 0;
    private float deltaTime = 0.0f;

    void Start()
    {
        objectCounter = 0;
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
    }

    public void Decrease()
    {
        objectCounter--;
    }
}
