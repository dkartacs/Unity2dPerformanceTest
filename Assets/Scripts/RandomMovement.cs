using UnityEngine;

public class RandomMovement : MonoBehaviour {

    public Rigidbody2D rd;
    public int force = 100;
    public float rate = 5;

    void Start () {
        InvokeRepeating("Nudge", 0, 1/rate);
    }

    private void Nudge()
    {
        rd.AddForce(RnJesus());
    }

    private Vector2 RnJesus()
    {
        return new Vector2(Random.Range(-force, force) * Time.deltaTime, Random.Range(-force, force) * Time.deltaTime);
    } 
}
