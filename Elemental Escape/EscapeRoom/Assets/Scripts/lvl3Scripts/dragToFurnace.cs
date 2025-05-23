using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class dragToFurnace : MonoBehaviour
{
    private bool dragging, placed1;
    private Vector2 offset, inventoryPos;
    public GameObject item, fe_replace;
    // public GameObject openFurnace;
    public GameObject key;
    // public ParticleSystem smoke;
    [SerializeField] GameObject _slot1, inventory_slot;


    void Start()
    {
        // smoke.Stop();
        // openFurnace.SetActive(false);
        key.SetActive(false);
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
            fe_replace.SetActive(true);
            // openFurnace.SetActive(true);
            // key.SetActive(true);
        }
        else
        {
            dragging = false;
            transform.position = inventory_slot.transform.position;
        }    
    }

    // void StartSmokeEffect()
    // {
    //     smoke.Play();
    //     Invoke("StopSmokeEffect", 3f);
    // }

    // void StopSmokeEffect()
    // {
    //     smoke.Stop();
    //     openFurnace.SetActive(true);
    //     key.SetActive(true);
    // }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
 
}
