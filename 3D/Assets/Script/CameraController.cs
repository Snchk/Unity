using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private Vector3 _angleOffset;
    [SerializeField] private float _clampRate;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position + _offset, _clampRate);
        transform.LookAt(_target.position + Vector3.up + _angleOffset);
    }
}
