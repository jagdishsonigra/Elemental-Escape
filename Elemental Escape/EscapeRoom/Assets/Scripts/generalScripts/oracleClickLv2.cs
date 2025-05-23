using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class oracleClickLv2 : MonoBehaviour
{
    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;
    public GameObject hint4;
    public GameObject hint5;
    public GameObject hint6;
    public GameObject hint7;
    

    private List<GameObject> hints = new List<GameObject>();
    private bool open = true;

    // Start is called before the first frame update
    void Start()
    {
        hints.Add(hint1);
        hints.Add(hint2);
        hints.Add(hint3);
        hints.Add(hint4);
        hints.Add(hint5);
        hints.Add(hint6);
        hints.Add(hint7);
       
        foreach (GameObject hint in hints)
        {
            hint.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {

        System.Random random = new System.Random();
        int randomIndex = random.Next(0, hints.Count);
        GameObject givenHint = hints[randomIndex];

        foreach (GameObject hint in hints)
        {
            hint.SetActive(false);
        }

        if (givenHint != null && open == true)
        {
            givenHint.SetActive(!givenHint.activeSelf);
        }
        open = !open;
    }
}