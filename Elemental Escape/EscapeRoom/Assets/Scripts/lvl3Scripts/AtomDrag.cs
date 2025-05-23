using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomDrag : MonoBehaviour
{
    private bool dragging, placed1, placed2, placed3, placed4;
    private Vector2 offset, inventoryPos;
    [SerializeField] GameObject _slot1, _slot2, _slot3, _slot4, inventory_slot, atom, circle1,circle2,circle3,circle4;
    // [SerializeField] GameObject _slot1, inventory_slot;


    void Update()
    {
        if(placed1)
        {
            return;
        }
        if(placed2)
        {
            return;
        }
        if(placed3)
        {
            return;
        }
        if(placed4)
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
            Destroy(circle1);
        }
        else if (_slot2 != null && Vector2.Distance(transform.position, _slot2.transform.position) < 1)
        {
            transform.position = _slot2.transform.position;
            placed2 = true;
            Destroy(circle2);
        }
        else if (_slot3 != null && Vector2.Distance(transform.position, _slot3.transform.position) < 1)
        {
            transform.position = _slot3.transform.position;
            placed3 = true;
            Destroy(circle3);
        }
        else if (_slot4 != null && Vector2.Distance(transform.position, _slot4.transform.position) < 1)
        {
            transform.position = _slot4.transform.position;
            placed4 = true;
            Destroy(circle4);
        }

        // if (Vector2.Distance(transform.position, _slot1.transform.position) < 1)
        // {
        //     transform.position = _slot1.transform.position;
        //     placed = true;
        //     Destroy(_slot1);
        // }
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