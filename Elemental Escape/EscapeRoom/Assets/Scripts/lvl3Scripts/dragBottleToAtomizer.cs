using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class dragBottleToAtomizer : MonoBehaviour
{
    private bool dragging, placed1;
    private Vector2 offset, inventoryPos;
    public GameObject item;
    public GameObject timer;
    public GameObject atom1;
    public GameObject atom2;
    public GameObject atom3;
    public GameObject atom4;
    public GameObject atom5;
    public GameObject atom6;
    public static bool isCountingDown = false;
    [SerializeField] GameObject _slot1, inventory_slot;

    void Start(){
        timer.SetActive(false);
        atom1.SetActive(false);
        atom2.SetActive(false);
        atom3.SetActive(false);
        atom4.SetActive(false);
        atom5.SetActive(false);
        atom6.SetActive(false);
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

        var mousePos = GetMousePosition();
        transform.position = mousePos - offset;
    }

    void OnMouseDown()
    {
        dragging = true;
        offset = GetMousePosition() - (Vector2)transform.position;
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

    Vector2 GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}