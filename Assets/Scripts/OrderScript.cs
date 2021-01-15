using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderScript : MonoBehaviour
{

    private Globals global;

    public GameObject orderCanvas;
    public GameObject sandsack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(global.getOrderScreen())
        {
            orderCanvas.SetActive(true);
        }
    }

    public void order(){
        int x = 0;
        for(int i=0; i<=5; i++)
            {
            Instantiate(sandsack, new Vector3(x, 0, 0), Quaternion.identity);
            x+=1;
            }
    }
}
