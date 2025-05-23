using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sofa_Lift : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject sofa;
    public GameObject note;
    [SerializeField] float z;
    private bool lifted = false;

    void Start()
    {
        note.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (lifted == false)
        {
            sofa.transform.rotation = Quaternion.Euler(0, 0, z);
            lifted = true;
            note.SetActive(true);
        }
        else
        {
            sofa.transform.rotation = Quaternion.Euler(0, 0, 0);
            lifted = false;
            note.SetActive(false);
        }
    }
}