using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class oracleClickLv4 : MonoBehaviour
{
    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;
    public GameObject hint4;
    public GameObject hint5;
    public GameObject hint6;
    public GameObject hint7;
    public GameObject hint8;
    public GameObject hint9;
    public GameObject hint10;
    public GameObject hint11;
    public GameObject hint12;
    public GameObject hint13;
    public GameObject hint14;
    public GameObject hint15;
    public GameObject hint16;
    public GameObject hint17;
    public GameObject hint18;
    public GameObject hint19;

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
        hints.Add(hint8);
        hints.Add(hint9);
        hints.Add(hint10);
        hints.Add(hint11);
        hints.Add(hint12);
        hints.Add(hint13);
        hints.Add(hint14);
        hints.Add(hint15);
        hints.Add(hint16);
        hints.Add(hint17);
        hints.Add(hint18);
        hints.Add(hint19);

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
