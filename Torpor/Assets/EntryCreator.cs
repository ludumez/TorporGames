using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;


//This script creates new entries and saves them in JSON form
public class EntryCreator : MonoBehaviour
{
    public EntryInfo entryInfo;
    [Space]
    public string saveFile;

    public void CreateEntry() {
        entryInfo.spritePath = AssetDatabase.GetAssetPath(entryInfo.entrySprite);

        string jsonString = JsonUtility.ToJson(entryInfo);
        saveFile = "Assets/SaveFiles/" + entryInfo.entryName + ".json";


        File.WriteAllText(saveFile, jsonString);
    }
}

[System.Serializable]
public class EntryInfo{
    public string entryName;
    public Sprite entrySprite;
   [HideInInspector] public string spritePath;
   [TextArea(3,20)] public string entryInformation;
}
