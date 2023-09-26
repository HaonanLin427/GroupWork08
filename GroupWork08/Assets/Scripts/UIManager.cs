using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI currentScoreCounter;
    private int currentScoreCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentScoreCounter.text = string.Format("CurrentScore:{0}", currentScoreCount);
    }

    // There is no score detail in this script, need to add it into the script of coin and link with UIManager in that script.

    public void UpdateCurrentScore(int Score)
    {
        currentScoreCount += Score;
        currentScoreCounter.text = string.Format("CurrentScore:{0}", currentScoreCount);
       
    }
    void Update()
    {
        
    }
}
