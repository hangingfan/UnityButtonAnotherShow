using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Chronos.Reflection;

[System.Serializable]
public class LocalizationItem
{
    public Button key;
    public Button.ButtonClickedEvent value;

    public void Init()
    {
        key.onClick = value;
    }
}
public class test : MonoBehaviour {

    [SerializeField]
    private LocalizationItem CreateButton;

    void Start()
    {
        CreateButton.Init();
    }

    public void HHHHHH()
    {
        Debug.Log("XXXXXXXXXX");
    }
}
