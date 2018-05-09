using UnityEngine;
using System.Linq;
using System.Collections;

public class FollowWaypoints : MonoBehaviour {

    public float speed = 1f;
    public float invokeRate = 0.1f;
    private GameObject[] waypoints;
    private int currentTarget = 0;

	void Start () {
        //Whoever thought that its a good idea to compare strings character by character should have been promplty hanged...
        waypoints = GameObject.FindGameObjectsWithTag("WayPoint").OrderBy(wp => wp.name.Length).ThenBy(wp=>wp.name).ToArray();
        if (GameObject.Find("EnemyManager") != null) {
            GameObject.Find("EnemyManager").GetComponent<EnemyManager>().Register(this);
        }
    }

    public void Move()
    {
        if (transform.position != waypoints[currentTarget].transform.position) {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentTarget].transform.position, speed);
        } else {
            if (waypoints.Length-1 > currentTarget) {
                currentTarget++;
            } else {
                currentTarget = 0;
            }
        }
    }

    public void RegisterInvoke()
    {
        InvokeRepeating("Move", 0, 1 / invokeRate);
    }

    public void RegisterCoroutine()
    {
        StartCoroutine(MoveCorotuine());
    }

    IEnumerator MoveCorotuine()
    {
        for (; ; ) {
            Move();
            yield return new WaitForSeconds(1 / invokeRate);
        }
    }
}

