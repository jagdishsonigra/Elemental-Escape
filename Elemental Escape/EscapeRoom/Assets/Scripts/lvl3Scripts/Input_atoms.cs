using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_atoms : MonoBehaviour
{

    public GameObject input_slots, fire_ex, door_open, confirm;
    // Start is called before the first frame update
    void Start()
    {
        input_slots.SetActive(false);
        fire_ex.SetActive(false);
        door_open.SetActive(false);
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if(input_slots != null)
        {
            input_slots.SetActive(true);
        }
    }
}
