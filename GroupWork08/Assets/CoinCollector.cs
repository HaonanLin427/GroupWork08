using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public delegate void CoinCollectedEventHandler(float score);

    public event CoinCollectedEventHandler CoinCollected;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Coin>() is Coin coin)
        {
            var score = coin.Collect();
            Debug.Log($"Collecting coin: {coin}, score: {score}");
            CoinCollected?.Invoke(score);
        }
    }
}
