using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NotesCreator))]
public class CustomNotesCreator : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        NotesCreator creator = (NotesCreator)target;
        GUILayout.Space(5);
        if (GUILayout.Button("Create note"))
        {
            creator.CreateNotes();
        }
    }
}
