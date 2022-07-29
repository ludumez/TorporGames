using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OptionsManager : MonoBehaviour
{
    private TMP_Text topicNameText;
   [SerializeField] public EntryInfo info;

    private string optionName;



    public void OnOptionCreated(TextAsset option)
    {
        info = JsonUtility.FromJson<EntryInfo>(option.ToString());



        optionName = info.entryName;
        topicNameText = transform.GetChild(0).GetComponent<TMP_Text>();
        topicNameText.text = optionName;
    }

    public void OnOptionSelected()
    {
        //tell the manager the option has been choosen and to display in the info panel

    }
}
