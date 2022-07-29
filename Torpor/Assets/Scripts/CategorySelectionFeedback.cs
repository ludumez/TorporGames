using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategorySelectionFeedback : MonoBehaviour
{
    public Sprite spriteOnSelected;
    public Sprite spriteOnNotSelected;

    public Color colorOnSeleted;
    public Color colorOnNotSeleted;

    private Image backGround;
    private Image icon;

    public void Seleted() {
        backGround = transform.GetChild(0).GetComponent<Image>();
        icon = backGround.transform.GetChild(0).GetComponent<Image>();


        icon.sprite = spriteOnSelected;
        backGround.color = colorOnSeleted;


    }

    public void UnSelected() {
        icon.sprite = spriteOnNotSelected;
        backGround.color = colorOnNotSeleted;
    }
}
