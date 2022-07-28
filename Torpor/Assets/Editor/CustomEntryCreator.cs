using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EntryCreator))]
public class CustomEntryCreator : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        EntryCreator creator = (EntryCreator)target;
        GUILayout.Space(5);
        if (GUILayout.Button("Create entry")) {
            creator.CreateEntry();
        }
    }
}
