using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    float currentTime=0f;
    float startingTime=3f;
    public GameObject atom;
    
    [SerializeField] TextMeshProUGUI countdown;

    void Start(){
        currentTime=startingTime;
        atom.SetActive(false);
    }

    void Update(){
        if(dragToAtomizer.isCountingDown){
            currentTime -= 1*Time.deltaTime;
            countdown.text= currentTime.ToString("0");
            if(currentTime<0){
                currentTime=0;
                atom.SetActive(true);
                countdown.enabled =false;
            }
        }
    }
}