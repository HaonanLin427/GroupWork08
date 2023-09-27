using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private const int CoinScore = 1;
    private UIManager uiManager;
    // Start is called before the first frame update
    private void awake() 
    {
        uiManager = FindObjectOfType<UIManager>();
    }

private void OnTriggerEnter2D(Collider2D collider)
{
    if (collider.CompareTag("Coin"))
    {
        // Destroy coins
        Destroy(collider.gameObject);
        if (uiManager != null)
        {
            uiManager.UpdateCurrentScore(CoinScore);
        }
        // and gain scores from coins
        // it links to the UI manager and gain score by using the method in UpdateCurrentScore
    }
}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
