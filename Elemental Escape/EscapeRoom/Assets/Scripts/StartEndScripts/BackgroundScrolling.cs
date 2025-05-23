using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector2 movespeed;
    Vector2 offset;
    Material material;
    void Awake() 
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = movespeed*Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
