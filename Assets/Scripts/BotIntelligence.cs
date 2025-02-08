using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BotIntelligence : MonoBehaviour
{
    // Start is called before the first frame update
    public Player PlayerComponent;
    public Transform Basket;

    // Update is called once per frame
    void Update()
    {
        var balls = GameObject.FindGameObjectsWithTag("Ball");
        if (balls.Length == 0)
            return;

        
        var candidateA = balls.Min(i => i.transform.position.x - Basket.position.x);
        var candidateB = balls.Max(i => i.transform.position.x - Basket.position.x);
        
        candidateA = Math.Abs(candidateA) < Math.Abs(candidateB) ? candidateA : candidateB;
        // if (Math.Abs(candidateA) < 0.1f)
        // {
        //     candidateA = 0;
        // }
        PlayerComponent.MoveVector = Math.Sign(candidateA);
        
    }
}
