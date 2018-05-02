using UnityEngine;

public class Tower : MonoBehaviour {

    public float rate = 1.0f;
    public float radius = 1.0f;
    public float laserLifetime = 0.05f;
    public LineSpawner lineSpawner;
    public PerformanceMonitor performanceMonitor;

    // Use this for initialization
    void Start () {
        InvokeRepeating("Remove", 0, 1 / rate);
    }
	
	// Update is called once per frame
	void Remove () {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies) {
            Vector3 difference = transform.position - enemy.transform.position;
            if (difference.sqrMagnitude <= radius) {
                Destroy(enemy);
                performanceMonitor.Decrease();
                lineSpawner.SpawnBetweenThenDestroy(transform.position, enemy.transform.position, laserLifetime);
                return;
            }
        }
    }
}
