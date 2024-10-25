using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countText;
    [SerializeField] private TextMeshProUGUI _winText;
    [SerializeField] private CoinSpawner _spawner;
    
    private int Count;

    public void CountReturn()
    {
        Count++;
    }
    
    private void Update()
    {
        if(Count != 0)
        {
            _countText.text = "Collected coins: " + Count;
        }
        if(Count == _spawner.CoinAmount)
        {
            _winText.text = "You won!";
            _winText.gameObject.SetActive(true);
        }
    }
}
