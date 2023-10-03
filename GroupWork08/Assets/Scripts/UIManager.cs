using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScoreCounter;

    void Update()
    {
        currentScoreCounter.text = string.Format("Current Score: {0,03}", ScoreKeeper.Instance.CurrentScore);
    }
}
