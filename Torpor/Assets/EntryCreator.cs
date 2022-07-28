using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class EntryCreator : MonoBehaviour
{
    public EntryInfo entryInfo;
    public string saveFile;

    private void Start()
    {
       
    }

    public void CreateEntry() {
        string jsonString = JsonUtility.ToJson(entryInfo);
        saveFile = "Assets/SaveFiles/" + entryInfo.entryName + ".json";


        File.WriteAllText(saveFile, jsonString);
    }
}

[System.Serializable]
public class EntryInfo{
    public string entryName;
    public Sprite entrySprite;
    public string entryInformation;
}
