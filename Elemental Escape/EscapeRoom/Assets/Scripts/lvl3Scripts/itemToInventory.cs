using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemToInventory : MonoBehaviour
{

    public GameObject item;
    public GameObject item2;
    public GameObject inventory;
    // [SerializeField] private AudioSource addItem;
    // Start is called before the first frame update
    void Start()
    {
        item.SetActive(true);
        // inventory.SetActive(false);
        item2.SetActive(false);
    }

    void OnMouseDown()
    {
        // addItem.Play();
        if(item != null)
        {
            inventory.SetActive(true);
            Destroy(item);
        }
    }
}
