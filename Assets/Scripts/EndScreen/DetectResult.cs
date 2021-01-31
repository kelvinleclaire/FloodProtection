using UnityEngine;

public class DetectResult : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Wenn das Wasser mit einem Checkpoint kollidiert, wird der State auf diesen gesetzt
        if (other.gameObject.tag.StartsWith("Check"))
        {
            switch (other.gameObject.tag)
            {
                case "Check10":
                    Globals.state = StateEnum.Lose;
                    break;
                case "Check40":
                    Globals.state = StateEnum.HaflWin;
                    break;
                case "Check80":
                    Globals.state = StateEnum.Win;
                    break;
            }
        }
    }
}
