using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateCanvas : MonoBehaviour
{
    public GameObject orderCanvas;

    public void close()
    {
        orderCanvas.SetActive(false);
    }
}
