using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoodDoor_lvl4 : MonoBehaviour
{
    public GameObject door;
    public GameObject tankO;
    public GameObject tankCO;
    public GameObject atom;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(false);
        tankO.SetActive(false);
        tankCO.SetActive(false);
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

        if (tankO != null)
        {
            tankO.SetActive(true);
        }

        if (tankCO != null)
        {
            tankCO.SetActive(true);
        }
    }
}
