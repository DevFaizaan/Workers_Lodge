using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectChecklist : MonoBehaviour
{

    //varaibles
    public string objName;
    public string description;
    public int index;

    public Text itemText;
    public Text itemDescText;

    public Button confirmButton;
    public Button deleteButton;

    
    private void Start()
    {
        //itemText = GetComponentInChildren<Text>();
        itemText.text = objName;

        //itemDescText = GetComponentInChildren<Text>();
        itemDescText.text = description;
    }

    public void SetObjectInfo(string name, string description, int index)
    {
        this.objName = name;
        this.description = description;
        this.index = index;
    }
}
