using UnityEngine;

public class RandomPositionSpawner : MonoBehaviour
{

    public GameObject spawnedObject;
    public PerformanceMonitor performanceMonitor;
    public float rate = 1.0f;
    public float spawnedAtOnce = 1.0f;

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
            Instantiate(spawnedObject, new Vector2(Random.Range(-10f,10f), Random.Range(-5.5f, 5.5f)), transform.rotation);
            performanceMonitor.Increase();
        }
    }

}
