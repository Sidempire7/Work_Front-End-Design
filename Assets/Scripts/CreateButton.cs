using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateButton : MonoBehaviour
{
    public TMP_InputField NameField;
    public Button createButton;


    private Color normalColor = new Color(19f, 152f, 144f, 1f);
    private Color disabledColor = new Color(19f, 152f, 144f, 1f);//0.5

    void Start()
    {
        createButton.GetComponentInChildren<Image>().color = disabledColor;

        createButton.interactable = false;

        

    }

    void Update()
    {
        if (NameField.text != "")
        {
            createButton.interactable = true;

            
        }
        else
        {
            createButton.interactable = false;

            createButton.GetComponentInChildren<Image>().color = disabledColor;

        }

    }
    
}
