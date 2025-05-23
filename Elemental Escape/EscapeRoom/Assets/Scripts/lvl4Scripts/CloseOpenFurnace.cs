using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseOpenFurnace : MonoBehaviour
{
    [SerializeField] public GameObject OpenFurnace;
    [SerializeField] public GameObject closeFurnace;

    [SerializeField] public GameObject a1;
    [SerializeField] public GameObject a2;
    [SerializeField] public GameObject a3;
    [SerializeField] public GameObject a1_replace, a2_replace, a3_replace;

    public ParticleSystem smokeEffect;

    private void Start()
    {
        smokeEffect.Stop();
    }
    void OnMouseDown()
    {
        
        if(a1 == null && a2 == null && a3 == null)
        {
            Destroy(a1_replace);
            Destroy(a2_replace);
            Destroy(a3_replace);
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
