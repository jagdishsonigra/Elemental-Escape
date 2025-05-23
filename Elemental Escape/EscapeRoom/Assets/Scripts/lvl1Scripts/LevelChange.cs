using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        // Load the next scene by name
        SceneManager.LoadScene("level2");
    }
}
