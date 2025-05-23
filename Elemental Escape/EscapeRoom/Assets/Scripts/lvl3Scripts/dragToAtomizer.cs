using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class dragToAtomizer : MonoBehaviour
{
    private bool dragging, placed1;
    private Vector2 offset, inventoryPos;
    public GameObject item;
    public GameObject timer;
    public GameObject atom;
    public static bool isCountingDown = false;
    [SerializeField] GameObject _slot1, inventory_slot;

    void Start(){
        timer.SetActive(false);
        atom.SetActive(false);
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
            Destroy(item);
            isCountingDown=true;
            timer.SetActive(true);
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