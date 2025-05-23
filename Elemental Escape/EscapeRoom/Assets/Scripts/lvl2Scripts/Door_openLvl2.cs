using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_openLvl2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject door_open, door, fire_ex, smoke;
    void OnMouseDown()
    {
        Destroy(door);
        Destroy(fire_ex);
        Destroy(smoke);
        door_open.SetActive(true);
    }
}
