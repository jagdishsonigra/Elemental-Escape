using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeRemove : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem smokeEffect;

    private void Start()
    {
        smokeEffect.Stop();
    }
}
