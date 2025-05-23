using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] GameObject followInterface;

    void LateUpdate()
    {
        transform.position = followInterface.transform.position + new Vector3(0, 0, -10);
    }

}
