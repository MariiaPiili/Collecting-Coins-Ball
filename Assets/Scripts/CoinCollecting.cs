using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollecting : MonoBehaviour
{
    [SerializeField] private CoinManager _manager;
    [SerializeField] private CoinSpawner _spawner;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CoinRotation>())
        {
            _spawner.DestroyCoin(other.gameObject);
            _manager.CountReturn();
        }
    }  
}
