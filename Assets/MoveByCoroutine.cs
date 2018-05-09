using UnityEngine;

public class MoveByCoroutine : MonoBehaviour {
	void Start () {
        gameObject.GetComponent<FollowWaypoints>().RegisterCoroutine();
    }
}
