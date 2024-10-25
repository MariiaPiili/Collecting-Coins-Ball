using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody _playerRigidbody;
    [SerializeField] private List<Vector3> _velocityList = new List<Vector3>();

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            _velocityList.Add(Vector3.zero);
        }
    }
    
    private void FixedUpdate()
    {
        _velocityList.Add(_playerRigidbody.velocity);
        _velocityList.RemoveAt(0);
    }

    private void Update()
    {
        Vector3 sum = Vector3.zero;
        for(int i =0; i < _velocityList.Count; i++)
        {
        sum += _velocityList[i]; 
        }
        transform.position = _playerTransform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(sum), Time.deltaTime*5);

        
    }
}
