using UnityEngine;

public class DeactivateCanvas : MonoBehaviour
{
    public GameObject orderCanvas;
    public GUIStyle style = new GUIStyle();
    string log = "";

    public void Close()
    {
        if (orderCanvas != null)
        {
            Globals.orderScreen = false;
            orderCanvas.SetActive(false);
        }
    }

    private void OnGUI()
    {
        //GUILayout.Label(log, style);
    }
}
