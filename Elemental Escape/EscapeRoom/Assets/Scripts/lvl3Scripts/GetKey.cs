using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject key, openFurnace, a, closeFurnace;
    void OnMouseDown()
    {   
        if(a == null)
        {
            openFurnace.SetActive(true);
            key.SetActive(true);
            closeFurnace.SetActive(false);
        }
    }
}
