using UnityEngine;

public class DirectedMovement : MonoBehaviour {

    public Rigidbody2D rd;
    public int force = 100;
    public float rate = 5;

    private GameObject target;

	void Start () {
        target = GameObject.Find("Tower");
        InvokeRepeating("MoveTo", 0, 1/rate);
    }
	
	private void MoveTo () {
        rd.AddForce((target.transform.position - transform.position) * force * Time.deltaTime);
	}
}
