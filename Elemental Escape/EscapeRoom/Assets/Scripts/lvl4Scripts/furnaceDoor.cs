using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class furnaceDoor : MonoBehaviour
{
    public GameObject door;
    
    public GameObject atom;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(false);
        
        atom.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (door != null)
        {
            door.SetActive(true);
        }

    }
}
