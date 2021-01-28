using UnityEngine;

public class OrderScript : MonoBehaviour
{


    public GameObject SandsackPlace;
    public GameObject Sandsack1Place;
    public GameObject orderCanvas;
    public GameObject sandsack;
    public GameObject City;
    public GUIStyle style = new GUIStyle();
    string log = "";
    private int id = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.orderScreen)
        {
            orderCanvas.SetActive(true);
        }
    }

    public void order()
    {
        Vector3 pos = SandsackPlace.transform.position;
        if (id <= 6)
        {
            for (int i = 0; i <2; i++)
            {
                sandsack = Instantiate(sandsack, pos, Quaternion.identity);
                sandsack.tag = $"Sandsack{id}";
                sandsack.transform.SetParent(City.transform);
                sandsack.transform.localScale = new Vector3(1f, 1f, 1f);
                sandsack.transform.localRotation = Quaternion.identity;
                pos = Sandsack1Place.transform.position;
                log += "Sandsack created: " + sandsack.tag + "\n";
                id++;
            }
            
        }

    }
    private void OnGUI()
    {
        GUILayout.Label(log, style);
    }
}
