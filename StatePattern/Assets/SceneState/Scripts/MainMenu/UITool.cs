using UnityEngine;
using UnityEngine.UI;

public class UITool : MonoBehaviour
{
    public Button Button;

    private static UITool instance;

    private void Start()
    {
        instance = this;
    }

    public static Button GetButton()
    {
        return instance.Button;
    }
}
