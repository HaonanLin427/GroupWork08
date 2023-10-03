using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScoreKeeper : MonoBehaviour
{
    private static ScoreKeeper instance;
    public static ScoreKeeper Instance => instance;

    [SerializeField] private int pointsPerPickup = 1;

    private int currentScore;
    public int CurrentScore => currentScore;

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

    public void IncreaseScore()
    {
        currentScore += pointsPerPickup;
    }
}
