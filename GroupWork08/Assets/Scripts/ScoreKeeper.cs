using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScoreKeeper : MonoBehaviour
{
    private static ScoreKeeper instance;
    public static ScoreKeeper Instance => instance;

    [SerializeField] private int pointsPerPickup = 1;

    private int player1Score;
    public int Player1Score => player1Score;
    private int player2Score;
    public int Player2Score => player2Score;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this);
        }
    }

    public void IncreaseScore(bool isPlayer1)
    {
        if(isPlayer1)
        {
            player1Score += pointsPerPickup;
        }
        else
        {
            player2Score += pointsPerPickup;
        }
    }
}
