using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeType : MonoBehaviour
{
    public GameObject codex;
    public GameObject notes;
    GameObject currentObject;

    private void Start()
    {
        currentObject = codex;
    }

    public void EnableObject(GameObject type) {
        currentObject.SetActive(false);
        currentObject = type;
        type.SetActive(true);
    }
}
