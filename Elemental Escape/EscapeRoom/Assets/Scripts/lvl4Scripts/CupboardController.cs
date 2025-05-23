using UnityEngine;

public class CupboardController : MonoBehaviour
{
    public GameObject openCupboardImage; // Assign the open cupboard image in the Inspector

    private void Start()
    {
        // Initially, disable the open cupboard image
        if (openCupboardImage != null)
        {
            openCupboardImage.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        // When the cupboard is clicked, toggle the visibility of the open cupboard image
        if (openCupboardImage != null)
        {
            openCupboardImage.SetActive(!openCupboardImage.activeSelf);
        }
    }
}
