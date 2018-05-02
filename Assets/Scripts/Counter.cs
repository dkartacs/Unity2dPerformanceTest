using UnityEngine;

public class Counter : MonoBehaviour {

    public static int counter = 0;

    public void Increase()
    {
        counter++;
    }

    public void Decrease()
    {
        counter--;
    }

}
