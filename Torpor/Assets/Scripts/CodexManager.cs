using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodexManager : MonoBehaviour
{
    [SerializeField]
    private CategoryManager currentCategory;



    public void CategorySeleted(CategoryManager currentCategory) {

        if (this.currentCategory!=null) this.currentCategory.DisableCategory();
        this.currentCategory = currentCategory;
        this.currentCategory.EnableCategory();
    }
}
