using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 180;
    
    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Player>(out var player))
        {
            Destroy(gameObject);
            ScoreKeeper.Instance.IncreaseScore();
        }
    }
}
