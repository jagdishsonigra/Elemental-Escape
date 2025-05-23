using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closePopUp : MonoBehaviour
{

    public GameObject openCupboard;
    bool opened = true;
    // Start is called before the first frame update
    void Start()
    {
 
    }

   
    void OnMouseDown()
    {
        if(opened == true)
        {
            openCupboard.SetActive(false);
        }
    }
}
