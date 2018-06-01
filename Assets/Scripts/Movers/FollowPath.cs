using Pathfinding;
using UnityEngine;
using System.Collections;

public class FollowPath : MonoBehaviour {

    public Path currentPath;
    public Seeker seeker;
    public float moveRate = 2f;
    public float moveSpeed = 10f;
    private GameObject target;
    private int currentTarget;

	void Start ()
    {
        target = GameObject.Find("Tower");
        UpdatePath();
    }

    void FixedUpdate()
    {
        Move();
    }

    private void UpdatePath ()
    {
        seeker.StartPath(transform.position, target.transform.position, OnPathComplete);
    }

    private void OnPathComplete(Path path)
    {
        if (!path.error) {
            currentPath = path;
            currentTarget = 0;
        } else {
            Debug.Log(path.error);
        }
    }

    private void Move()
    {
        if (currentPath == null) {return;}
        if (transform.position != currentPath.vectorPath[currentTarget]) {
            transform.position = Vector3.MoveTowards(transform.position, currentPath.vectorPath[currentTarget], Time.deltaTime * moveSpeed);
        } else {
            if (currentPath.vectorPath.Count - 1 > currentTarget) {
                currentTarget++;
            } 
        }
    }
}
