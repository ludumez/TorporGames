using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ACTManager : MonoBehaviour
{

    public ACTData currentACT;
    public GameObject information;
    public TMP_InputField inputField;

    //hides all the notes. Then looks gets all the notes from 
    public void OnACTSeleted(ACTData data) {
        Debug.Log(JsonUtility.FromJson<NotesData>(data.ACT.ToString()));

        if (currentACT!=null) {
            //hides the previos notes
            for (int i = 0; i < information.transform.childCount; i++)
            {
                information.transform.GetChild(i).gameObject.SetActive(false);

                information.transform.GetChild(i).GetComponentInChildren<NotesInformationManager>().CancelDelete();
                information.transform.GetChild(i).GetComponentInChildren<DeleteNote>().ResetImage();
            }
        }
       
        currentACT = data;


        //shows the new notes
        for (int i = 0; i < currentACT.note.listOfNotes.Count; i++)
        {
            information.transform.GetChild(i).gameObject.SetActive(true);
            information.transform.GetChild(i).GetComponent<NotesInformationManager>().UpdateInformation(currentACT.note.listOfNotes[i]);
        }
    }

    //Called from the add a note button
    public void AddNewNote() {
        currentACT.note.listOfNotes.Add(inputField.text);
        inputField.text = "";
        OnACTSeleted(currentACT);
    }

    public void RemoveNote(int index) {
        currentACT.note.listOfNotes.RemoveAt(index); 
        OnACTSeleted(currentACT);
    }
}
