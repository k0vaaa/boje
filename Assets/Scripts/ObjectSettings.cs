using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;
using System;


public class ObjectSettings : MonoBehaviour
{
    /*public ObjectManipulator _objman;*/
    private GameObject _selected;
    private PlayerMoney _script;
    public GameObject _combined;
    private BtnClicker _btn;
    void Start()
    {
        /*objectManipulator = GetComponent<ObjectManipulator>();*/
        _script = FindObjectOfType<PlayerMoney>();
        /*_objman = FindObjectOfType<ObjectManipulator>();*/
        _btn = FindObjectOfType<BtnClicker>();
    }

    void Update()
    {
        _selected =  GameObject.Find("SELECTED");

    }
    public void DeleteObj()
    {
        if (GameObject.Find("SELECTED"))
        {
            Destroy(GameObject.Find("SELECTED"));
            _script.CounterReturn();
        }
             
    }

    public void ChangeColour()
    {
        /*_selected = GameObject.Find("SELECTED");
        var _render = _selected.GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));*/
        _btn.ColourWindowOpen();

    }


    public void ChangeColour1()
    {
        _selected = GameObject.Find("SELECTED");
        var _render = _selected.GetComponent<Renderer>().material.color = Color.white;
        _btn.ColourWindowClose();
    }
    public void ChangeColour2()
    {
        _selected = GameObject.Find("SELECTED");
        var _render = _selected.GetComponent<Renderer>().material.color = Color.grey;
        _btn.ColourWindowClose();
    }
    public void ChangeColour3()
    {
        _selected = GameObject.Find("SELECTED");
        var _render = _selected.GetComponent<Renderer>().material.color = Color.red;
        _btn.ColourWindowClose();
    }
    public void ChangeColour4()
    {
        _selected = GameObject.Find("SELECTED");
        var _render = _selected.GetComponent<Renderer>().material.color = Color.green;
        _btn.ColourWindowClose();
    }
    public void ChangeColour5()
    {
        _selected = GameObject.Find("SELECTED");
        var _render = _selected.GetComponent<Renderer>().material.color = Color.blue;
        _btn.ColourWindowClose();
    }
    public void ChangeColour6()
    {
        _selected = GameObject.Find("SELECTED");
        var _render = _selected.GetComponent<Renderer>().material.color = Color.yellow;
        _btn.ColourWindowClose();
    }











    public void CombineObjects()
    {

        /*Instantiate(_combined);*/
        /*_selected = GameObject.Find("SELECTED");*/

        /*_combined.transform.position = _selected.transform.position;*/
        /*smthn.gameObject.AddComponent<BoxCollider>();*/

        /*smthn.AddComponent<ObjectManipulator>();*/
        var linkedObjs = GameObject.FindGameObjectsWithTag("Combined");
      
        for (int i = 0; i < linkedObjs.Length; i++)
        {   
            /*linkedObjs[i].transform.SetParent(_selected.transform, true);*/
            linkedObjs[i].transform.parent = _selected.transform;
        }
        

    }

    public void CombineMark()
    {
        _selected = GameObject.Find("SELECTED");
        _selected.tag = "Combined";
        print("meow");
    }

}