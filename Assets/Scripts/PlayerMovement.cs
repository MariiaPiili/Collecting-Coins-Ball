using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _camera;
    [SerializeField] private int _speed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        _rigidbody.AddTorque(_camera.right * Input.GetAxis("Vertical") * _speed);
        _rigidbody.AddTorque(_camera.forward * (-Input.GetAxis("Horizontal")) * _speed);
    }
}
