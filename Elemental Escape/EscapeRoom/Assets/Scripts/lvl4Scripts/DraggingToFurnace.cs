using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggingToFurnace : MonoBehaviour
{
    private bool dragging, placed1, placed2;
    private Vector2 offset, inventoryPos;
    [SerializeField] GameObject _slot, inventory_slot, a, a_replace;
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
        if (_slot != null && Vector2.Distance(transform.position, _slot.transform.position) < 1)
        {
            transform.position = _slot.transform.position;
            placed1 = true;
            Destroy(a);
            a_replace.SetActive(true);
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