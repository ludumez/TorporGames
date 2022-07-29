using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CategoryManager : MonoBehaviour
{
    public GameObject topics;
    public TMP_Text categoryDescriptionText;

    public void DisableCategory() {
        topics.SetActive(false);

        //swaps the sprite and colors to unseleted ones 
        GetComponent<CategorySelectionFeedback>().UnSelected();
    }

    public void EnableCategory() {
        topics.SetActive(true);
        categoryDescriptionText.text = gameObject.name;
        //Swaps the sprites and color to the seleted ones
        GetComponent<CategorySelectionFeedback>().Seleted();
    }
}
