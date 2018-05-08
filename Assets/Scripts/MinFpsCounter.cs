using UnityEngine;
using UnityEngine.UI;

public class MinFpsCounter : MonoBehaviour
{

    public Text text;

    void Start()
    {
        text.text = "" + GameController.MinFps;
    }

    public void SetText(float count)
    {
        text.text = "" + count;
    }
}
