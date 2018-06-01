using UnityEngine;
using UnityEngine.UI;

public class SceneDescriptionToggle : MonoBehaviour {
    public GameObject text;
    public GameObject button;

	public void ShowDescription()
    {
        text.SetActive(true);
        button.SetActive(false);
    }
}
