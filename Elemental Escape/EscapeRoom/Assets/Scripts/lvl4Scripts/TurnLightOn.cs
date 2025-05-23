using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightOn : MonoBehaviour
{

    public GameObject DarkRoom;
    public GameObject CorrectSparkle ;
    public GameObject Sparkle1 ;
    public GameObject Sparkle2 ;
    public GameObject Sparkle3 ;
    public GameObject Sparkle4 ;
    public GameObject Neon;
    bool opened = true;
    // Start is called before the first frame update
    void Start()
    {
        Neon.SetActive(false);
    }

   
    void OnMouseDown()
    {
        if(opened == true)
        {
            DarkRoom.SetActive(false);
            CorrectSparkle.SetActive(false);
            Sparkle1.SetActive(false);
            Sparkle2.SetActive(false);
            Sparkle3.SetActive(false);
            Sparkle4.SetActive(false);
            Neon.SetActive(true);
        }
    }
}
