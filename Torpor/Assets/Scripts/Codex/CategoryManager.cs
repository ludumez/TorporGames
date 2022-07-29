using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryManager : MonoBehaviour
{
    public GameObject topics;

    public void DisableCategory() {
        topics.SetActive(false);

        //swaps the sprite and colors to unseleted ones 
        GetComponent<CategorySelectionFeedback>().UnSelected();
    }

    public void EnableCategory() {
        topics.SetActive(true);

        //Swaps the sprites and color to the seleted ones
        GetComponent<CategorySelectionFeedback>().Seleted();
    }
}
