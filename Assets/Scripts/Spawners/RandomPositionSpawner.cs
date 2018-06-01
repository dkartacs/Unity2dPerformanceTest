using UnityEngine;

public class RandomPositionSpawner : MonoBehaviour
{

    public GameObject spawnedObject;
    public PerformanceMonitor performanceMonitor;
    public float rate = 1.0f;
    public float spawnedAtOnce = 1.0f;
    public float xAxisMinimum = -10f;
    public float xAxisMaximum = 10f;
    public float yAxisMinimum = -5.5f;
    public float yAxisMaximum = 5.5f;

    void Start()
    {
        if (performanceMonitor == null) {
            performanceMonitor = GameObject.Find("PerformanceMonitor").GetComponent<PerformanceMonitor>();
        }
        InvokeRepeating("Spawn", 1, 1 / rate);
    }

    private void Spawn()
    {
        for (int i = 0; i < spawnedAtOnce; i++) {
            Instantiate(spawnedObject, new Vector2(Random.Range(xAxisMinimum, xAxisMaximum), Random.Range(yAxisMinimum, yAxisMaximum)), transform.rotation);
            performanceMonitor.Increase();
        }
    }

}
