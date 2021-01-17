using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCanvas : MonoBehaviour
{
    public GameObject orderCanvas;

    void Close()
    {
        orderCanvas.SetActive(false);
    }
}
