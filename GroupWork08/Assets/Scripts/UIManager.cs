using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI player1Score;
    [SerializeField] private TextMeshProUGUI player2Score;

    void Update()
    {
        player1Score.text = string.Format("Player 1: {0}", ScoreKeeper.Instance.Player1Score);
        player2Score.text = string.Format("Player 2: {0}", ScoreKeeper.Instance.Player2Score);
    }
}
