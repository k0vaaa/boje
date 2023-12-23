using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

public class BtnClicker : MonoBehaviour
{
    public GameObject mainWindow;
    public GameObject settingsWindow;
    public GameObject colourWindow;
    private MenuAR _script;
    
    public void Start()
    {
        settingsWindow.SetActive(false);
        _script = FindObjectOfType<MenuAR>();
        
    }
    public void CreateSomething()
    {
        settingsWindow.SetActive(true);
        colourWindow.SetActive(false);
        mainWindow.SetActive(false);
    }
    public void ColourWindowOpen()
    {
        colourWindow.SetActive(true);
    }
    public void ColourWindowClose()
    {
        colourWindow.SetActive(false);
    }



    public void HidePlate()
    {
        
        settingsWindow.SetActive(false);
        mainWindow.SetActive(true);
        StartCoroutine(UpdateBtnCollection());

    }
    private IEnumerator UpdateBtnCollection()
    {
        yield return new WaitForSeconds(1);
        _script.UpdateButtons();
        
    }
}