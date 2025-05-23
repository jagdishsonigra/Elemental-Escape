using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseFurnace : MonoBehaviour
{
    [SerializeField] public GameObject OpenFurnace;
    [SerializeField] public GameObject closeFurnace;

    [SerializeField] public GameObject a1;

    [SerializeField] public GameObject a1_replace;

    public ParticleSystem smokeEffect;

    private void Start()
    {
        smokeEffect.Stop();
    }
    void OnMouseDown()
    {
        
        if(a1 == null)
        {
            Destroy(a1_replace);
            closeFurnace.SetActive(true);
            OpenFurnace.SetActive(false);
            StartSmokeEffect();
        }
    }
    private void StartSmokeEffect()
    {
        smokeEffect.Play(); 
        Invoke("StopSmokeEffect", 3f);
    }

    private void StopSmokeEffect()
    {
        smokeEffect.Stop();
    }
}
