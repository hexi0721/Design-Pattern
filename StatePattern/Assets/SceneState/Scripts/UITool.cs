using UnityEngine;
using UnityEngine.UI;

public class UITool : MonoBehaviour
{
    [SerializeField] private Button button;
    public static UITool Instance { get; set; }

    public Button GetButton()
    {
        return button;
    }
}
