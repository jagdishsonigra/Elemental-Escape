using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject drawer;
    public GameObject rand_items;
    public GameObject active_carbon;
    void Start()
    {
        drawer.SetActive(false);
        rand_items.SetActive(false); 
        active_carbon.SetActive(false);
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (drawer != null)
        {
            drawer.SetActive(true);
        }
        if (rand_items != null)
        {
            rand_items.SetActive(true);
        }
        if (active_carbon != null)
        {
            active_carbon.SetActive(true);
        }
    }
}
