using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUpMiddle : MonoBehaviour
{

    public GameObject objectToAppear;
    private GameObject spawnedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in the world
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Check if the click position is over an object
            Collider2D clickedCollider = Physics2D.OverlapPoint(clickPosition);

            if (clickedCollider != null && clickedCollider.gameObject == gameObject)
            {
                // Clicked on the current object
                if (spawnedObject == null)
                {
                    // If the object is not currently visible, instantiate it
                    Vector2 screenCenter = new Vector2(Screen.width / 2, Screen.height / 2);
                    Vector2 worldCenter = Camera.main.ScreenToWorldPoint(screenCenter);
                    spawnedObject = Instantiate(objectToAppear, worldCenter, Quaternion.identity);
                }
                else
                {
                    // If the object is already visible, destroy it
                    Destroy(spawnedObject);
                    spawnedObject = null;
                }
            }
            else
            {
                // Clicked somewhere else, destroy the objectToAppear if it exists
                if (spawnedObject != null)
                {
                    Destroy(spawnedObject);
                    spawnedObject = null;
                }
            }
        }
    }
}
