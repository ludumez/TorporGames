using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACTData : MonoBehaviour
{
    public TextAsset ACT;
    public NotesData note;
    private void Start()
    {
      note=  Note();
    }

    public NotesData Note() {
        //needs to be updated everytime you look at it since the information may changeno
        NotesData notes = JsonUtility.FromJson<NotesData>(ACT.ToString());
        return notes;
    }
}
