using UnityEngine;

public class MoveByInvokeRepeating : MonoBehaviour {

	void Start () {
        gameObject.GetComponent<FollowWaypoints>().RegisterInvoke();
	}
}
