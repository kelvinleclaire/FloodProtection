using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{
    // private bool orderScreen {get; set;}
    private bool orderScreen = false;

    public bool getOrderScreen(){
        return orderScreen;
    }

    public void setOrderScreen(bool b){
        orderScreen = b;
    }
}
