using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConnectButton : MonoBehaviour
{
     public TMP_InputField NameField;
    public Button connectButton;
    public Button joinButton;

    private Color normalColor = new Color(19f, 152f, 144f, 1f);
    private Color disabledColor = new Color(19f, 152f, 144f, 1f);//0.5

    void Start()
    {
        connectButton.GetComponentInChildren<Image>().color = disabledColor;
        joinButton.GetComponentInChildren<Image>().color = disabledColor;
        connectButton.interactable = false;
        joinButton.interactable=false;
    }

    void Update()
    {
        if (NameField.text != "")
        {
            connectButton.interactable = true;
            joinButton.interactable=true;
            
        }
        else
        {
            joinButton.interactable=false;
            connectButton.interactable = false;
            connectButton.GetComponentInChildren<Image>().color = disabledColor;
            joinButton.GetComponentInChildren<Image>().color = disabledColor;
        }
        
    }
    
}
