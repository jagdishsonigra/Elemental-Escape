using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUp : MonoBehaviour
{

    public GameObject openCupboard;
    // Start is called before the first frame update
    void Start()
    {
        openCupboard.SetActive(false);
    }

   
    void OnMouseDown()
    {
        if(openCupboard != null)
        {
            openCupboard.SetActive(true);
           
        }
    }
}
