using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLose_Drawer : MonoBehaviour
{
    // Start is called before the first frame update
    bool opened = true;
    public GameObject drawer;
    public GameObject rand_items;
    public GameObject active_carbon;
    void OnMouseDown()
    {
        if(opened == true)
        {
            drawer.SetActive(false);
            rand_items.SetActive(false);
            if(active_carbon!=null)
            {
                active_carbon.SetActive(false);
            }
        }
    }
}
