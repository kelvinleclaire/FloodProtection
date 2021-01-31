using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    // private bool orderScreen {get; set;}
    public static bool orderScreen { get; set; }
    public static bool timeOver { get; set; }
    public static bool endGame { get; set; }
    public static StateEnum state { get; set; } = StateEnum.Win;

    public static void Init()
    {
        orderScreen = false;
        timeOver = false;
        endGame = false;
        state = StateEnum.Win;
    }

}
