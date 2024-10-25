using UnityEngine;

public class ArrowMoveement : MonoBehaviour
{
    [SerializeField] private CoinSpawner _coinSpawner;

    private GameObject _currentTarget;

    private void Update()
    {
        _currentTarget = _coinSpawner.Coins[0];

        for (int i = 1; i < _coinSpawner.Coins.Count; i++)
        {
            if (Vector3.Distance(transform.position, _coinSpawner.Coins[i].transform.position) < Vector3.Distance(transform.position, _currentTarget.transform.position))
            {
                _currentTarget = _coinSpawner.Coins[i];
            }
        }
        if (_currentTarget != null)
        {
            Vector3 direction = _currentTarget.transform.position - transform.position;
            transform.rotation = Quaternion.LookRotation(direction);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
