using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class OptionsInformationDisplay : MonoBehaviour
{
    public GameObject informationBlock;

    private TMP_Text title;
    private TMP_Text information;
    private Image image;

    [Space]
    private OptionsManager currentOptionSelected;
    public TMP_FontAsset fontOnEntrySelected;
    public TMP_FontAsset defaultFont;
    private void Start()
    {

    }

    //Called from the Options buttons
    public void OnEntryChosen(OptionsManager optionsManager) {



        title = informationBlock.transform.GetChild(0).GetComponent<TMP_Text>();
        image = informationBlock.transform.GetChild(1).GetComponent<Image>();
        information = informationBlock.transform.GetChild(2).GetComponent<TMP_Text>();



        title.text = optionsManager.info.entryName;
        information.text = optionsManager.info.entryInformation;

        //load the image from a url where the sprite was located during the creation of the entry
        //Only show image if there is one saved
        if (optionsManager.info.spritePath == "")
        {
            image.gameObject.SetActive(false);
        }
        else
        {
            image.gameObject.SetActive(true);
            image.sprite = AssetDatabase.LoadAssetAtPath(optionsManager.info.spritePath, typeof(Sprite)) as Sprite; 
        }

        //Change the font of the selected entry as visual feedback
       if (currentOptionSelected!=null) currentOptionSelected.GetComponentInChildren<TMP_Text>().font = defaultFont;
        currentOptionSelected = optionsManager;
        currentOptionSelected.GetComponentInChildren<TMP_Text>().font = fontOnEntrySelected;

    }

    public void test() { 
    
    }
}
