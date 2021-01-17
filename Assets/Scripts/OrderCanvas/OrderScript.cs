using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderScript : MonoBehaviour
{



    public GameObject orderCanvas;
    public GameObject sandsack;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(Globals.orderScreen)
        {
            orderCanvas.SetActive(true);
        }
    }

    public void order(){
        float x = -0.7f;
        for(int i=2; i<4; i++)
            {
            // Local Coordiates = -3.9, 0.5, 3.9
            if (Globals.sandsackPosition != null)
            {
                sandsack = Instantiate(sandsack, Globals.sandsackPosition, Quaternion.identity);
                //sandsack.transform.localPosition = new Vector3(x, 0.5f, 3.92f);
                sandsack.tag = $"Sandsack{i}";
                x -= 1.49f;
            }
            }
    }
}
