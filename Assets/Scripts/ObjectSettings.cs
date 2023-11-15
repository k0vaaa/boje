using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;
using System;



public class ObjectSettings : MonoBehaviour
{
    private GameObject _selected;
    private PlayerMoney _meow;
    void Start()
    {   
        _meow = FindObjectOfType<PlayerMoney>();
    }
    public void DeleteObj()
    {
        if (GameObject.Find("SELECTED"))
        {
            Destroy(GameObject.Find("SELECTED"));
            _meow.CashBack();
        }
             
    }

    public void ChangeColour()
    {
        _selected =  GameObject.Find("SELECTED");
        var _render = _selected.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f);
    }
    /*static float RandomGenerator()
    {
        var rnd = Random.Range(0f, 1f);
        return rnd;
    }*/

}
