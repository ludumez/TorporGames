using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NotesCreator : MonoBehaviour
{
    public static NotesCreator current;

    private void Start()
    {
        current = this;
    }


    public NotesData notes;
    [Space]
    public string saveFile;
    public string noteName;
    public void CreateNotes() {

        string jsonString = JsonUtility.ToJson(notes);
        saveFile = "Assets/SaveFiles/" + noteName + "note.json";

        File.WriteAllText(saveFile, jsonString);
    }

    public void AddNotes(ACTData data, string noteToAdd) {
        //get the notes
        NotesData currentNote = JsonUtility.FromJson<NotesData>(data.ACT.ToString());
        //Add new note
        currentNote.listOfNotes.Add(noteToAdd);
        //save the new notes
        string jsonString = JsonUtility.ToJson(currentNote);
        saveFile = "Assets/SaveFiles/" + data.ACT.name + ".json";

        File.WriteAllText(saveFile, jsonString);

    }

    public void RemoveNotes(int index) { 
  
    }
}

[System.Serializable]
public class NotesData{
    public List<string> listOfNotes;
}
