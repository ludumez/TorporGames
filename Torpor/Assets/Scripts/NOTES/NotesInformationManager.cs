using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NotesInformationManager : MonoBehaviour
{
    public Color colorForDelete;
    Color defaultColor;

    TMP_Text text;

    public void UpdateInformation(string note) {

        text = transform.GetChild(0).GetComponent<TMP_Text>();
        text.text = note;
        defaultColor = Color.black;
    }

    public void SetToDelete() {
        text.color = colorForDelete;
    }

    public void CancelDelete() {
        text = transform.GetChild(0).GetComponent<TMP_Text>();

        text.color = Color.black;
    }
}
