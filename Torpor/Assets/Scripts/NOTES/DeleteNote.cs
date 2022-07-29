using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DeleteNote : MonoBehaviour, IPointerClickHandler
{
    bool isReady;
    public Sprite originalImage;
    public Color originalColor;
    public Sprite deleteImage;
    public Color deleteColor;

    public ACTManager manager;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isReady)
        {
            GetComponentInParent<NotesInformationManager>().SetToDelete();

            GetComponent<Image>().sprite = deleteImage;
            GetComponent<Image>().color = deleteColor;
            isReady = true;
        }
        else
        {
            GetComponentInParent<NotesInformationManager>().CancelDelete();
            manager.RemoveNote(transform.parent.GetSiblingIndex());
            ResetImage();
            isReady = false;
        }
    }


    public void ResetImage()
    {
        GetComponent<Image>().sprite = originalImage;
        GetComponent<Image>().color = originalColor;
        isReady = false;

    }
}
