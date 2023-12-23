using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    public GameObject child;

    public void Update()
    {
        SetParent();
    }    
    
    
    public void SetParent()
    {
         child.transform.parent = this.gameObject.transform;
    }

}
