using UnityEngine;
using Pathfinding;

public class TargetSetter : MonoBehaviour {

    void Start () {
        GetComponent<AIDestinationSetter>().target = GameObject.Find("Tower").transform;
	}

    public void SetTarget(GameObject target)
    {
        GetComponent<AIDestinationSetter>().target = target.transform;
    }
}
