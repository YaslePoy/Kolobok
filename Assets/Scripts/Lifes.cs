using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifes : MonoBehaviour
{
    public static Lifes Singleton;
    public int Life;
    public int MaxLife;
    public GameObject LifesHolder;
    public Image BadForeground;
    // Start is called before the first frame update
    void Start()
    {
        Singleton = this;
        Life = MaxLife;
    }

    // Update is called once per frame
    
    public void SubstractLife()
    {
        --Life;
        if (Life <= 0)
        {
            Life = MaxLife;
            foreach (var score in FindObjectsOfType<PlayerScore>())
            {
                score.Score = -1;
                score.RegisterScore();
            }
        }

        var hearts = LifesHolder.GetComponentsInChildren<SpriteRenderer>();
        for (int i = 0; i < MaxLife; i++)
        {
            hearts[i].enabled = i + 1 <= Life;
        }

        BadForeground.enabled = Life == 1;
    }
}
