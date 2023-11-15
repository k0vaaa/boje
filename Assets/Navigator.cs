using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Navigator : MonoBehaviour
{

    private BtnClicker _btnClicker;
    public bool _selected;

    void Start()
    {
        _btnClicker = FindObjectOfType<BtnClicker>();
    }

    public void DoSomtn()
    {
        _btnClicker.CreateSomething();
    }

    public void HideSettings()
    {
        _btnClicker.HidePlate();
    }


    public void GetSelected()
    {
        foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
        {
            if (gameObj.name == "SELECTED")
            {
                gameObj.name = "NOT SELECTED";
            }
        }

        gameObject.name = "SELECTED";
    }
}

