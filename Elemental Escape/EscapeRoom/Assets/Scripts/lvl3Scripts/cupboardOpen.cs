using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupboardOpen : MonoBehaviour
{
    public GameObject door;
    public GameObject cupboard;
    public GameObject openCupboard;
    private bool dragging, placed1;
    private Vector2 offset, inventoryPos;
    public GameObject item;
    [SerializeField] GameObject _slot1, inventory_slot;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
        cupboard.SetActive(false);
        openCupboard.SetActive(false);
    }

     void Update()
    {
        if(placed1)
        {
            return;
        }
        if (!dragging)
        {
            return;
        }

        var mousePos = GetMousePos();
        transform.position = mousePos - offset;
    }

    void OnMouseDown()
    {
        dragging = true;
        offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp()
    {   
        if (_slot1 != null && Vector2.Distance(transform.position, _slot1.transform.position) < 1)
        {
            transform.position = _slot1.transform.position;
            placed1 = true;
            item.SetActive(false);
            door.SetActive(false);
            cupboard.SetActive(true);
        }
        else
        {
            dragging = false;
            transform.position = inventory_slot.transform.position;
        }
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}

