using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 180;
    [SerializeField] private float score = 1;
    
    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
    }

    public float Collect()
    {
        Destroy(gameObject);
        return score;
    }
}
