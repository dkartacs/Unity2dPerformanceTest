using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Text text;
    private int count = 0;

    void Start()
    {
        InvokeRepeating("Time", 0, 1f);
    }

    public void Time()
    {
        text.text = "" + count++;
    }
}
