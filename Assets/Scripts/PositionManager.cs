using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionManager : MonoBehaviour
{
    [SerializeField] public GameObject _camera;
    public Vector3 _camDir;
    public Vector3 _camPos;

    void Update()
    {
        _camDir = _camera.transform.forward;
        _camPos =  _camera.transform.position;
    }
}
