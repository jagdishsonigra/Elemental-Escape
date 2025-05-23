using System.Collections;
using System.Collections.Generic;
using UnityEngine;
   
    public class skipPosition : MonoBehaviour
    {
        public GameObject skip_button;
        [SerializeField] public int x,y,z;
    void Start()
        {
            Vector3 position1 = new Vector3(x,y,z);
          //attach Game Object go to target
            skip_button.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 5f + position1;
        }
    }