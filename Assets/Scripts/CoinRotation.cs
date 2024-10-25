using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{    
    [SerializeField] private Vector3 _rotation;    
    
    private void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }
}
