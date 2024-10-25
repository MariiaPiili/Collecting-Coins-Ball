using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public List<GameObject> Coins = new List<GameObject>();
    public int CoinAmount => _coinAmount;

    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private int _coinAmount;
    [SerializeField] private float _positionXMax;
    [SerializeField] private float _positionXMin;    
    [SerializeField] private float _positionY;
    [SerializeField] private float _positionZMin;
    [SerializeField] private float _positionZMax;

    private void Start()
    {
        for(int i = 0; i < _coinAmount; i++)
        {
            Vector3 position = new Vector3(Random.Range(_positionXMin,_positionXMax), _positionY, Random.Range(_positionZMin,_positionZMax));
            GameObject newCoin = Instantiate(_coinPrefab, position, Quaternion.identity);
            Coins.Add(newCoin);
        }
    }

    public void DestroyCoin(GameObject coin)
    {
        Coins.Remove(coin);
        Destroy(coin);
    }
}
