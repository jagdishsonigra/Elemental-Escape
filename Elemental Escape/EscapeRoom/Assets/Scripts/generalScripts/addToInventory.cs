using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addToInventory : MonoBehaviour
{
    public GameObject atom;

    // Start is called before the first frame update
    void Start()
    {   if(atom != null)
    {
        atom.SetActive(false);
    }
    }

    // Update is called once per frame
    void Update()
    {
        // Add any necessary update logic here
    }

    private void OnMouseDown()
    {

        if (atom != null)
        {
            atom.SetActive(true);
        }

        Destroy(gameObject);
        
    }
}
