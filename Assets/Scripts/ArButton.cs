using Microsoft.MixedReality.Toolkit.UI;
using System;
using System.Collections.Specialized;
using TMPro;
using UnityEngine;

public class ArButton : MonoBehaviour
{
    public event Action OnButtonClicked;
    [SerializeField] private TextMeshPro _title;
    [SerializeField] private Interactable _interactable;
    private GameObject _prefab;
    /*private PositionManager _posmanager;*/
    private BtnClicker _btn;

    void Start()
    {
        /*_posmanager = FindObjectOfType<PositionManager>();*/
        _btn = FindObjectOfType<BtnClicker>();
    }



    public void Initialize(Item config)
    {
        _title.text = config.Title;
        _prefab = config.pref;
        _interactable.OnClick.AddListener(ProcessClick);


    }
    private void ProcessClick()
    {
        OnButtonClicked?.Invoke();
        CreateSomething();  
    }

    public void CreateSomething()   
    {
        var pos = new Vector3(_btn.mainWindow.transform.position.x, _btn.mainWindow.transform.position.y + 0.1f, _btn.mainWindow.transform.position.z+0.3f);
        var dir = _btn.mainWindow.transform.forward;
        /*_posmanager._camPos = new Vector3(_posmanager._camPos.x, _posmanager._camPos.y + 0.5f, _posmanager._camPos.z);*/
        /*var newobject =  Instantiate(_prefab, (_posmanager._camPos + _posmanager._camDir), new Quaternion());*/
        var newobject = Instantiate(_prefab, (pos + dir), new Quaternion());
        newobject.name = "NOT SELECTED";
    }
}
