using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batBubble : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bubble;
    private bool bubbleOn=false;
    void Start()
    {
        bubble.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        if(!bubbleOn)
        {bubble.SetActive(true);
        bubbleOn=true;}
        else{
            bubble.SetActive(false);
            bubbleOn=false;
        }
    }
}
