using UnityEngine;

public class Preloader : MonoBehaviour {

    public GameObject spawnedObject;
    public PerformanceMonitor performanceMonitor;
    public int numberOfSpawn;

    void Awake () {
        if (performanceMonitor == null) {
            performanceMonitor = GameObject.Find("PerformanceMonitor").GetComponent<PerformanceMonitor>();
        }
        for(int i = 0; i < numberOfSpawn; i++) {
            Instantiate(spawnedObject, new Vector2(Random.Range(-10f, 10f), Random.Range(-5.5f, 5.5f)), transform.rotation);
            //Instantiate(spawnedObject, new Vector3(Random.Range(100f, 1000f), Random.Range(-5.5f, 5.5f), 5f), transform.rotation);
            performanceMonitor.Increase();
        }
    }
}
