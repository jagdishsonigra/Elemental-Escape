using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrolling : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float moveSpeed = 20;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, -2.5f, 15.5f),
            Mathf.Clamp(transform.position.y, 0, 0)
        );
        transform.Translate(moveAmount, 0, 0);
    }
}
