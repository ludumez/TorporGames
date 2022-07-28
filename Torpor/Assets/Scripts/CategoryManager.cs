using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryManager : MonoBehaviour
{
    public GameObject topics;

    public void DisableCategory() {
        topics.SetActive(false);
    }

    public void EnableCategory() {
        topics.SetActive(true);
    }
}
