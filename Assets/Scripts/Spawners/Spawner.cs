﻿using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject spawnedObject;
    public PerformanceMonitor performanceMonitor;
    public float rate = 1.0f;
    public float spawnedAtOnce = 1.0f;

	void Start () {
        if (performanceMonitor == null) {
            performanceMonitor = GameObject.Find("PerformanceMonitor").GetComponent<PerformanceMonitor>();
        }
        InvokeRepeating("Spawn", 1, 1/rate);
    }

    private void Spawn()
    {
        for (int i = 0; i < spawnedAtOnce; i++) {
            Instantiate(spawnedObject, transform.position, transform.rotation);
            performanceMonitor.Increase();
        }
    }

}
