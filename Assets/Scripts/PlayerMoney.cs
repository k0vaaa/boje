using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using UnityEngine;



public class PlayerMoney: MonoBehaviour
{
    [SerializeField] public int _counterAmmount;
    [SerializeField] private TextMeshPro _counterSign;
    private int startAmmount;
    private MenuAR _meow;


    public void Start()
    {
        startAmmount = _counterAmmount;
       _meow =  FindObjectOfType<MenuAR>();
    }
    
    public void Update()
    {
        _counterSign.text = _counterAmmount.ToString();
        
    }




    public void ProcessBuy()
    {
        if (_counterAmmount - 1 < 0)
        {
            return;
        }
        _counterAmmount -= 1;
        _counterSign.text = _counterAmmount.ToString();
    }

    public void CashBack()
    {
        if (startAmmount > _counterAmmount) 
        {
            _counterAmmount += 1;
        }
        
    }


    public bool CanBuy()
    {
        return _counterAmmount - 1 >= 0;
    }   
}
