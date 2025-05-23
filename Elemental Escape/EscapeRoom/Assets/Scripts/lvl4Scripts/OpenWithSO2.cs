using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWithSO2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject so2, openFurnace, a;
    void OnMouseDown()
    {   
        if(a == null)
        {
            openFurnace.SetActive(true);
            so2.SetActive(true);
        }
    }
}
