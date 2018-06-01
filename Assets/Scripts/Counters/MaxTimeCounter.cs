using UnityEngine;
using UnityEngine.UI;

public class MaxTimeCounter : MonoBehaviour {

    public Text text;

    void Start()
    {
        text.text = "" + GameController.MaxRunTime;
    }

    public void SetText(float count)
    {
        text.text = "" + count;
    }
}
