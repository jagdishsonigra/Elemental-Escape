using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSO3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject so3,so2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown() 
    {
        Destroy(so3);   
        Destroy(so2);
    }
}
