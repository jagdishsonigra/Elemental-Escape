using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapperinventory : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject a;
    void Start()
    {
        a.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
