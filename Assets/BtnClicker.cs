using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

public class BtnClicker : MonoBehaviour
{
    public GameObject mainWindow;
    public GameObject settingsWindow;
    private MenuAR _antosha;

    public void Start()
    {
        settingsWindow.SetActive(false);
        _antosha = FindObjectOfType<MenuAR>();
    }

    public void CreateSomething()
    {
        settingsWindow.SetActive(true);
        mainWindow.SetActive(false);
    }

    public void HidePlate()
    {
        
        settingsWindow.SetActive(false);
        mainWindow.SetActive(true);
        StartCoroutine(Gadza());

    }

    private IEnumerator Gadza()
    {
        yield return new WaitForSeconds(1);
        _antosha.UpdateButtons();
        
    }

}