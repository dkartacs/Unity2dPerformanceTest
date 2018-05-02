using Pathfinding;
using UnityEngine;
using System.Collections;

public class FollowPath : MonoBehaviour {

    public Rigidbody2D rd;
    public Seeker seeker;
    public int force = 100;
    public float applyMovementRate = 5;
    public float pathUpdateRate = 2f;
    public float switchWaypointDistance = 2;
    private GameObject target;
    private Path path;
    private int currentWaypoint;

	void Start () {
        target = GameObject.Find("Tower");
        StartCoroutine(UpdatePath());
        InvokeRepeating("Move", 0, 1 / applyMovementRate);
    }
	
	private IEnumerator UpdatePath () {
        seeker.StartPath(transform.position, target.transform.position, OnPathComplete);
        yield return new WaitForSeconds(1f/ pathUpdateRate);
        StartCoroutine(UpdatePath());
    }

    private void OnPathComplete(Path p)
    {
        path = p;
        currentWaypoint = 0;
    }

    private void Move()
    {
        if (path == null) return;
        if (currentWaypoint >= path.vectorPath.Count) {
            //Debug.Log("No movement: " + currentWaypoint + " " + path.vectorPath.Count);
            return;
        }
        //try out what if i store it here
        //Vector3 targetPosition = path.vectorPath[currentWaypoint];

        rd.AddForce((path.vectorPath[currentWaypoint] - transform.position) * force * Time.deltaTime);
        float distanceToTargetWaypoint = Vector3.Distance(transform.position, path.vectorPath[currentWaypoint]);
        if (distanceToTargetWaypoint< switchWaypointDistance) {
            currentWaypoint++;
            return;
        }
    }
}
