using Pathfinding;
using UnityEngine;
using System.Collections;

public class FollowPath : MonoBehaviour {

    public Rigidbody2D rd;
    public Seeker seeker;
    public int force = 100;
    public float pathUpdateRate = 2f;
    private GameObject target;

	void Start () {
        target = GameObject.Find("Tower");
        InvokeRepeating("UpdatePath", 0, 1 / pathUpdateRate);
    }

    private void UpdatePath () {
        seeker.StartPath(transform.position, target.transform.position, OnPathComplete);
    }

    private void OnPathComplete(Path path)
    {
        //(path.vectorPath[1] - transform.position) -> this basically gives the direction
        //Time.deltaTime -> this normalizes the speed. This is needed otherwise different framerates fuck up the calculation
        //- ((Vector3)rd.velocity) -> makes the speed constant (otherwise we just continuously adding force and Newton fucks up everything.)
        rd.AddForce((path.vectorPath[1] - transform.position) * force * Time.deltaTime - ((Vector3)rd.velocity));
    }
}
