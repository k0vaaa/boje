using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public partial class MenuAR : MonoBehaviour
{
    [SerializeField] private ItemsCFG _itemsCFG;
    [SerializeField] private GameObject _btnPref;
    [SerializeField] private Transform _root;
    [SerializeField] private GridObjectCollection _gridObjectCollection;
    [SerializeField] private PlayerMoney _playerMoney;

    public void Start()
    {
        UpdateButtons();
    }
    public void UpdateButtons()
    {   
        for (int i=0; i<_root.childCount; i++)
        {
            Destroy(_root.GetChild(i).gameObject);
        }

        foreach (var itemsConfigItem in _itemsCFG.items)
        {
            if (!_playerMoney.CanBuy()) 
            {
                continue;
            }

            var button = Instantiate(_btnPref, _root);

            if (button.TryGetComponent(out ArButton arButton))
            {
                arButton.Initialize(itemsConfigItem);
            }
            arButton.OnButtonClicked += () => ProcessBuy();
        }

        StartCoroutine(UpdateCollection());
    }

    private void ProcessBuy()
    {
        _playerMoney.ProcessBuy();
        UpdateButtons();
    }
    private IEnumerator UpdateCollection()
    {
        yield return new WaitForEndOfFrame();
        _gridObjectCollection.UpdateCollection();
    }

}



