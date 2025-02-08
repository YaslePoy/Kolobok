using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private int _maxScore;
    public int Score;
    public Text ScoreText;
    
    public void RegisterScore()
    {
        ++Score;
        if (Score >= _maxScore)
        {
            _maxScore = Score;
        }

        ScoreText.text = $"Score:\n{Score}\nMax.:\n{_maxScore}";
    }
}
