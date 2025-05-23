using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    // Start is called before the first frame update

    public ParticleSystem smokeEffect;
    [SerializeField] GameObject a1,a2,a3;

    private void Start()
    {
        smokeEffect.Stop(); // Make sure the smoke effect is initially stopped.
    }

    private void OnMouseDown()
    {
        if(a1 == null && a2 == null && a3 == null)
        {
            StartSmokeEffect();
        }
    }

    private void StartSmokeEffect()
    {
        smokeEffect.Play(); // Start the smoke effect.

        // Invoke a method to stop the smoke effect after 3 seconds.
        Invoke("StopSmokeEffect", 3f);
    }

    private void StopSmokeEffect()
    {
        smokeEffect.Stop(); // Stop the smoke effect.
    }
}
