/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

*//*[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]*//*

public class ObjectCombiner : MonoBehaviour
{

    // Update is called once per frame
    public void CombineMeshes()
    {
        Child.transform.parent = Parent.transform;
    }
}
*/